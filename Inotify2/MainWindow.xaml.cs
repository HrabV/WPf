using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace Inotify2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public Student studentData { get; set; } = new Student();


        void Serialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            var serial = JsonConvert.SerializeObject(studentData);
            File.WriteAllText(path, serial);
        }

        void Deserialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            string output = File.ReadAllText(path);
            var deserial = JsonConvert.DeserializeObject<Student>(output);
            studentData = deserial;

           

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var t = studentData;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Serelize_Click(object sender, RoutedEventArgs e)
        {
            Serialize();
        }

        private void Deserelize_Click(object sender, RoutedEventArgs e)
        {
            Deserialize();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            TB1.Clear();
            TB2.Clear();
            TB3.Clear();
            TB4.Clear();
            TB5.Clear();
            TB6.Clear();


        }
    }




}
