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
    /// Interaction logic for installedApps.xaml
    /// </summary>
    public partial class installedApps : Window
    {
        public installedApps()
        {
            InitializeComponent();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
