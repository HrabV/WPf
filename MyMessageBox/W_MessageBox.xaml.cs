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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyMessageBox
{
    /// <summary>
    /// Interaction logic for W_MessageBox.xaml
    /// </summary>
    public partial class W_MessageBox : Window
        
    {

        public string ReturnString { get; set; }
       // private string text;

        public W_MessageBox(string Text, MineMessageBox.Buttons buttons)
        {
           InitializeComponent();
           txbText.Text = Text;
            switch (buttons)
            {
                case MineMessageBox.Buttons.Yes_No:
                    buttonNO.Visibility = Visibility.Visible;
                    buttonYes.Visibility = Visibility.Visible;
                    break;
                case MineMessageBox.Buttons.OK:
                    buttonOK.Visibility = Visibility.Visible;
                    break;
              
            }
        }

        //public W_MessageBox(string text, MineMessageBox.Buttons buttons)
        //{
        //    this.text = text;
        //    this.buttons = buttons;
        //    switch (buttons)
        //    {
        //        case MineMessageBox.Buttons.Yes_No:
        //            buttonNO.Visibility = Visibility.Visible;
        //            buttonYes.Visibility = Visibility.Visible;
        //            break;
        //        case MineMessageBox.Buttons.OK:
        //            buttonOK.Visibility = Visibility.Visible;
        //            break;
        //        default:
        //            break;
        //    }
        //}

            //public W_MessageBox(string text, MineMessageBox.Buttons buttons) : this(text)
            //{
            //    switch (buttons)
            //    {
            //        case MineMessageBox.Buttons.Yes_No:
            //            buttonNO.Visibility = Visibility.Visible;
            //            buttonYes.Visibility = Visibility.Visible;
            //            break;
            //        case MineMessageBox.Buttons.OK:
            //            buttonOK.Visibility = Visibility.Visible;
            //            break;
            //        default:
            //            break;
            //    }

            //}

            //public W_MessageBox(string text)
            //{
            //    this.text = text;
            //}

            private void GBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try { DragMove(); }
            catch { }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = "-1";
            Close();
        }

        DoubleAnimation anim;
        

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(0.3));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Height = (txbText.LineCount * 27) + gBar.Height + 60;
        }

        private void btnReturnValue_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = ((Button)sender).Uid.ToString();
            Close();
        }
    }
}
