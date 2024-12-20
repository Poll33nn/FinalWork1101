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
using ServiceLayer.Models;
using ServiceLayer.Services;

namespace FragrantWorld.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        private readonly UserService _userService = new();
        public AuthPage()
        {
            InitializeComponent();
        }

        private async void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                bool isUserExist = await _userService.IsUserExist(LoginTextBox.Text, PasswordBox.Password);

                if (isUserExist)
                {
                    var user = await _userService.GetUserNameByLogin(LoginTextBox.Text);
                    MessageBox.Show($"Добро пожаловать {user.Name}", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    App.CurrentFrame.Navigate(new ShopPage(user));
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно", "Ошикбка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошикбка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EnterAsGuestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы вошли как гость", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            App.CurrentFrame.Navigate(new ShopPage());
        }
    }
}
