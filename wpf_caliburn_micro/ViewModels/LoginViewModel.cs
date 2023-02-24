using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpf_caliburn_micro.ViewModels.Commands;

namespace wpf_caliburn_micro.ViewModels
{
    internal class LoginViewModel : Screen 
    {

        public string username { get; set; } = string.Empty;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }

        public bool rememberMe { get; set; }
        public bool RememberMe
        {
            get => rememberMe;
            set
            {
                rememberMe = value;
                NotifyOfPropertyChange(() => RememberMe);
            }
        }

        public ICommand? LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new LoginCommand((string password) =>
            {
                MessageBox.Show(username + password + rememberMe.ToString());
            });
        }
    }
}
