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

namespace Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string getParent;
        public MainWindow()
        {
            InitializeComponent();
            getParent = LogicalTreeHelper.GetParent(buttonTask).ToString();
        }

        private void buttonTask_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(labelLogicalType.GetType().Name);
            var f = LogicalTreeHelper.GetParent(labelLogicalType);
            while (f!=null)
            {
                sb.Append("->" + f.GetType().Name);
                f = LogicalTreeHelper.GetParent(f);
            }

            labelLogicalType.Content = sb.ToString();


        }

        private void buttonTask1_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(labelVisualType.GetType().Name);
            var f = LogicalTreeHelper.GetParent(labelVisualType);
            while (f!=null)
            {
                sb.Append("->" + f.GetType().Name);
                f = VisualTreeHelper.GetParent(f);

            }

            labelVisualType.Content = sb.ToString();
        }
    }
}
