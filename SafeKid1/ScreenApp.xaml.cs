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
        private readonly viewModel viewModel;
        public ScreenApp()
        {
            InitializeComponent();
            this.viewModel = new viewModel
            {
                DataGridItems = new List<appList>()
                {
                    new appList
                    {
                        nameApp="Chrome",
                        startTime="12PM",
                        endTime="14PM"
                    }

                }

            };
            this.DataContext = this.viewModel;
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
        private void button_installed(object sender, RoutedEventArgs e)
        {
            installedApps subWindow1 = new installedApps();
            subWindow1.Show();

        }

        private void Dataweb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        public void hienthi()
        {
            
        }
    }
}
