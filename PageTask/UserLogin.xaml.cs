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

namespace PageTask
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Page
    {
       
        public UserLogin()
        {
            InitializeComponent();
            
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("UserContent.xaml", UriKind.RelativeOrAbsolute));
            
        }

      

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            MainWindow.Log = TB1.Text;
            MainWindow.Pass = TB2.Text;


        }
    }
}
