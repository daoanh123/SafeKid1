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
    /// Interaction logic for listView.xaml
    /// </summary>
    public partial class listView : Window
    {
        public listView()
        {
            InitializeComponent();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void txtClear()
        {
            DomainTxt.Clear();
                }
        private void AddList(object sender, RoutedEventArgs e)
        {
                
            ListDomain.Items.Add(DomainTxt.Text);
            txtClear();

        }
        private void remove(object sender, RoutedEventArgs e)
        {
            if (ListDomain.SelectedItem != null)
                ListDomain.Items.Remove(ListDomain.SelectedItem);
            txtClear();
        }
    }
}
