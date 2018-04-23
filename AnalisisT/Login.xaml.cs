using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnalisisT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        // Se tiene una única cuenta con estas credenciales, de manera que lo que se coloca
        // en el input se utiliza para crear un usuario con ese user y password, y se verifica
        // si son correctos contra estos datos
        string Username = "Xamarin";
        string Password = "password";
        public Login()
        {
            InitializeComponent();
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn 
                    = true;
                await Navigation.PushModalAsync(new MainTabbed());
            }
            else
            {
                messageLabel.Text = "Error en el inicio de sesión";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Username && user.Password == Password;
        }
    }
}