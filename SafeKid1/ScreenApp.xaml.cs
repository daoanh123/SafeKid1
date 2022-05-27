using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SafeKid1
{
    /// <summary>
    /// Interaction logic for MainApp.xaml
    /// </summary>
    public partial class ScreenApp : Window
    {
        public ScreenApp()
        {
            InitializeComponent();
        }
        private void Toggle_btn1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_setting(object sender, RoutedEventArgs e)
        {
            listView subWindow1 = new listView() ;
            subWindow1.Show();
            
        }
    }
}
