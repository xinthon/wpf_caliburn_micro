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
    internal class MainViewModel : Conductor<object>                                                                                                                                                                                                                                                                                                       
    {
        public ICommand TestingRelayCommand { get; }

        public MainViewModel()
        {
            this.ActiveItem = new ShellViewModel();

            TestingRelayCommand = new RelayCommand((object? param) =>
            {
                MessageBox.Show(param?.ToString() ?? "");
            });
        }
    }
}
