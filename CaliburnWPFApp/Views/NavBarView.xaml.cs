
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvxElebris.Wpf.Views
{
    public partial class NavBarView
    {

        public NavBarView()
        {
            InitializeComponent();
         
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {

            // Set tooltip visibility

        }
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { 
            //Toggle button checked = false;
        }
            
        private void toggle_Button_Unchecked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 1;
        }

        private void toggle_Button_Checked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
        }
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            //Close();
        }
    }
}
