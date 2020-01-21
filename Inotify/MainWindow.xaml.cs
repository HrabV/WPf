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

namespace Inotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public Student studentData { get; set; } = new Student();


        void Serialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            // Tuple<string, string, string, string, string, string> studentinfo = new Tuple<string, string, string, string, string, string>(studentData.Name, studentData.Group, studentData.Gender, studentData.BirthdayDay, studentData.Weight, studentData.Height);
            //var serial = JsonConvert.SerializeObject(studentinfo);
            var serial = JsonConvert.SerializeObject(studentData);
            File.WriteAllText(path, serial);
        }

        void Deserialize()
        {
            string path = $"{Environment.CurrentDirectory}/save.json";
            string output = File.ReadAllText(path);

            //var deserial = (Tuple<string, string, string, string, string, string>)JsonConvert.DeserializeObject(output, typeof(Tuple<string, string, string, string, string, string>));
            //studentData.Name = deserial.Item1;
            //studentData.Group = deserial.Item2;
            //studentData.Gender = deserial.Item3;
            //studentData.BirthdayDay = deserial.Item4;
            //studentData.Weight = deserial.Item5;
            //studentData.Height = deserial.Item6;

            var deserial = JsonConvert.DeserializeObject<Student>(output);
            studentData = deserial;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(studentData)));

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
