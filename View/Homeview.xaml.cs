using Multiple_Tab_Creation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multiple_Tab_Creation.View
{
    /// <summary>
    /// Interaction logic for Homeview.xaml
    /// </summary>
    public partial class Homeview : UserControl
    {
        public Homeview()
        {
            InitializeComponent();
         //S   DataContext = new HomeViewModel();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txt2.Text = string.Empty;

        }
        private void txt1_GotFocus(object sender, RoutedEventArgs e)
        {
             txt1.Text = string.Empty;
            
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
