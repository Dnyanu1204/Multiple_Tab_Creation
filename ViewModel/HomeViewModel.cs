using Multiple_Tab_Creation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Multiple_Tab_Creation.MyCommand;
namespace Multiple_Tab_Creation.ViewModel
{
    class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<HomeModel> Id_list { get; set; }
        public ObservableCollection<HomeModel> Students
        {
            get;
            set;
        }
        public string surenames="Last Name";
        public string Surenames
        {
            get { return surenames; }
            set
            {
                surenames = value;
                OnPropertyChanged(nameof(Surenames));
                OnPropertyChanged(nameof(Fullnames));
     



            }
        }

        public string fullnames;
        public string Fullnames
        {
            get
            {
                return fullnames;
            }
            set
            {
                fullnames = $"{Names} {Surenames}";



            }
        }

        public ICommand AddRecordCommand
        {
            get
            {
                return new Mycommand(AddRecord);
            }
        }
        public void focus()
        {
            Names = string.Empty;
        }

        public ICommand Focuscommand
        {
            get
            {
                return new Mycommand(focus);
            }
        }
        public ICommand DeleteRecordCommand
        {
            get
            {
                return new Mycommand(DeleteRecord);
            }
        }
        public void AddRecord()
        {
            if(Surenames!="Last Name" && Names!="First Name" && Surenames!=string.Empty && Names!=string.Empty )
            {
                int val = Students.Count() + 1;
                Students.Add(new HomeModel(val.ToString(), Names, Surenames));
            }

           
        }
        public void DeleteRecord()
        {
          
            Students.Remove(Student);
        }
        public HomeViewModel()
        { 

            Students=new ObservableCollection<HomeModel>();
        
            //Students.Add(new HomeModel("1", "Dnyaneshwari", "Narwade"));

        }
       

        string names = "First Name";
        public string Names
        {
            get
            {
                return names;
            }
            set
            {
                names = value;
                OnPropertyChanged(nameof(Names));
                OnPropertyChanged(nameof(Fullnames));


            }
        }

       
        public HomeModel student;
        public HomeModel Student{
            get
            {
                return student;
            }
            set
            {
                student = value;
                OnPropertyChanged(nameof(Student));
            }
            }
       
    

    }
}
