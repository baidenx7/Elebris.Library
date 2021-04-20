using System.Windows;
using System.Windows.Input;

namespace CaliburnWPFApp.Views
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
