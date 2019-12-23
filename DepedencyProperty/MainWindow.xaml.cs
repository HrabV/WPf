using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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


namespace DepedencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged 
    {
        // public static readonly DependencyProperty TestTextProperty = DependencyProperty.Register("TextTestProperty", typeof(string), typeof(Window));
        //       public string TestText { get => (string)GetValue(TestTextProperty); set => SetValue(TestTextProperty, value); }
        public string TestText;

        public event PropertyChangedEventHandler PropertyChanged;

        public UserLoger userLog { get; set; } = new UserLoger();

        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var t = userLog;

        }

        void Serialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            Tuple<string, string> userinfo = new Tuple<string, string>(userLog.User, userLog.Password);
            var serial = JsonConvert.SerializeObject(userinfo);
            File.WriteAllText(path, serial);
        }

        void Deserialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            string output = File.ReadAllText(path);
            var deserial = (Tuple<string, string>)JsonConvert.DeserializeObject(output, typeof(Tuple<string, string>));
            userLog.User = deserial.Item1;
            userLog.Password = deserial.Item2;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(userLog)));

        }



        private void Serelize_Click(object sender, RoutedEventArgs e)
        {

            Serialize();
           

        }

        private void Deserelize_Click(object sender, RoutedEventArgs e)
        {

            Deserialize();
           
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }


}
