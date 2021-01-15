using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Wpf.Views;
using MvxElebris.Core.ViewModels;
using System.Windows;

namespace MvxElebris.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MvxWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //Set tooltip visibility
            if(toggle_Button.IsChecked == true)
            {
                tt_actions.Visibility = Visibility.Collapsed;
                tt_attribute.Visibility = Visibility.Collapsed;
                tt_derived.Visibility = Visibility.Collapsed;
                tt_equipment.Visibility = Visibility.Collapsed;
                tt_roles.Visibility = Visibility.Collapsed;
                tt_stats.Visibility = Visibility.Collapsed;
                tt_login.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_actions.Visibility = Visibility.Visible;
                tt_attribute.Visibility = Visibility.Visible;
                tt_derived.Visibility = Visibility.Visible;
                tt_equipment.Visibility = Visibility.Visible;
                tt_roles.Visibility = Visibility.Visible;
                tt_stats.Visibility = Visibility.Visible;
                tt_login.Visibility = Visibility.Visible;
            }
        }

        private void toggle_Button_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void toggle_Button_Checked(object sender, RoutedEventArgs e)
        {

            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            toggle_Button.IsChecked = false;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
