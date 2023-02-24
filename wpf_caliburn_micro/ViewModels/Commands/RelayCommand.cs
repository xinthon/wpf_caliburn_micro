using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_caliburn_micro.ViewModels.Commands
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        private Action<object?>? execute { get; set; }
        private Func<object?, bool>? canExecute { get; set; }


        public RelayCommand(Action<object?>? execute, Func<object?, bool>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute?.Invoke(parameter);
        }
    }
}
