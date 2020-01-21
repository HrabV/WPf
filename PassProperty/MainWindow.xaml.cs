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

namespace PassProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty PasswordProperty;
        public string Password { get => (string)GetValue(PasswordProperty); set => SetValue(PasswordProperty, value); }

        public MainWindow()
        {
            InitializeComponent();
        }


        static MainWindow()
        {
            PasswordProperty = DependencyProperty.Register(nameof(Password), typeof(string), typeof(MainWindow), new PropertyMetadata("********", new PropertyChangedCallback(OnPasswordChanged)));
        
        }

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)

        {
            var oldvalue = e.OldValue;
            var newValue = e.NewValue;
            var dp = e.Property;

            throw new NotImplementedException();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var s = 10;
        }

        private void okButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var s = 10;

        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var a = 10;

        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var a = 10;
          

        }

        private void Grid_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            var a = 10;

        }

        private void PassWindow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var a = 10;

        }

        private void StackPanel_MouseMove(object sender, MouseEventArgs e)
        {

            StP2.Background = Brushes.Brown;
        }

        private void StP2_MouseLeave(object sender, MouseEventArgs e)
        {

            StP2.Background = Brushes.Beige;


        }
    }
}
