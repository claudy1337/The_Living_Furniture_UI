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
using The_Living_Furniture_UI.Pages.others;


namespace The_Living_Furniture_UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          // PagesNavigation.Navigate(new System.Uri("Pages/others/User.xaml", UriKind.RelativeOrAbsolute));
            User user = new User();
            user.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void btnMinimize_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void btnClose_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
    }
}
