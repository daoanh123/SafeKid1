using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly viewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            

        }
        
       private void ButtonLogin(object sender, RoutedEventArgs e)
        {
            var pass = Password.Password.ToString();

            string p4ss;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse");
            if (key != null)
            {
                try
                {
                    p4ss = key.GetValue("Name").ToString();
                    if (pass == p4ss)
                    {
                        ScreenApp subWindow1 = new ScreenApp();
                        subWindow1.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("co cl p4ss");
                    }

                }
                catch
                {
                    MessageBox.Show("chưa co p4sss");
                }
            }
           

           


        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
           
        }
       

    }
      

}
