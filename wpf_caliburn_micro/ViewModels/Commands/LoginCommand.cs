using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace wpf_caliburn_micro.ViewModels.Commands
{
    internal class LoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<string>? _action;

        public LoginCommand(Action<string>? action)
        {
            _action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is PasswordBox)
            {
                var passwordBox = parameter as PasswordBox;
                var password = passwordBox?.Password ?? "";
                _action?.Invoke(password);
            }
        }
    }
}
