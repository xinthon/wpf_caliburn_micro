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
    internal class MainViewModel : Screen
    {
        public ICommand TestingRelayCommand { get; }

        public MainViewModel()
        {
            TestingRelayCommand = new RelayCommand((object? param) =>
            {
                MessageBox.Show(param?.ToString() ?? "");
            });
        }
    }
}
