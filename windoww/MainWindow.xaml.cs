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

namespace windoww
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICommand
    {
        string getParent;
        public MainWindow()
        {
            InitializeComponent();
            getParent = LogicalTreeHelper.GetParent(buttonTask).ToString();
        }
       

        public readonly static RoutedUICommand Generate;
        public readonly static RoutedUICommand Clear;
        private bool isTreefill ;

        static MainWindow()
        {
            Generate = new RoutedUICommand("Tree generation", "Generate", typeof(MainWindow));
            Clear = new RoutedUICommand("Tree clearing", "Clear", typeof(MainWindow));

        }
        public event EventHandler CanExecuteChanged;

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RestoreDown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonTask1_Click(object sender, RoutedEventArgs e)
        {
            labelLogicalType.Content = null;
            labelVisualType.Content = null;

        }

        private void buttonTask_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(labelVisualType.GetType().Name);
            var f = LogicalTreeHelper.GetParent(labelVisualType);
            while (f != null)
            {
                sb.Append("->" + f.GetType().Name);
                f = VisualTreeHelper.GetParent(f);

            }
            labelVisualType.Content = sb.ToString();
            StringBuilder sd = new StringBuilder();
            sd.Append(labelLogicalType.GetType().Name);
            var d = LogicalTreeHelper.GetParent(labelLogicalType);
            while (d != null)
            {
                sd.Append("->" + d.GetType().Name);
                d = LogicalTreeHelper.GetParent(d);
            }
            labelLogicalType.Content = sd.ToString();
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isTreefill;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isTreefill;
        }
    }
}
