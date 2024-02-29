using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiple_Tab_Creation.MyCommand;
using System.Windows.Input;
namespace Multiple_Tab_Creation.ViewModel
{
    class MainViewModel:BaseViewModel
    {

       
        public BaseViewModel currentchildview;
        public BaseViewModel CurrentChildView
        {
            get
            {
                return currentchildview;
            }
            set
            {
                currentchildview = value;
                OnPropertyChanged(nameof(CurrentChildView));
                
            }
        }
        public MainViewModel()
        {
          
            HomePageCommand = new Mycommand(Homepage);
            AboutPageCommand = new Mycommand(Aboutpage);
           

        }
       public ICommand HomePageCommand { get; }
       
           
        

        public ICommand AboutPageCommand { get; }
        
        public void Homepage()
        {
            CurrentChildView = new HomeViewModel();
        }
        public void Aboutpage()
        {
            CurrentChildView = new AboutViewModel();
        }
       
    }
}
