using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Multiple_Tab_Creation.ViewModel
{
    class BaseViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
        // Invoke the event handler if not null
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
     }
}

}
