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
using The_Living_Furniture_UI.Pages.userPages;

namespace The_Living_Furniture_UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
            
            
        }
        private void RegistrationPage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }

        private void Bauth_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Show();
            
        }

        private void TBforgotPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
