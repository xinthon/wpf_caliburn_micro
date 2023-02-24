using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf_caliburn_micro.Helpers;
using wpf_caliburn_micro.ViewModels.Commands;

namespace wpf_caliburn_micro.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        //
        
        public ShellViewModel()
        {
            this.ActiveItem = new HomeViewModel();

            UpdateCurrentView = new RelayCommand((object? param) =>
            {
                if(param == null)
                {
                    return;
                }

                dynamic viewType = (ViewType) param;

                switch (viewType)
                {
                    case ViewType.Home:
                        this.ActiveItem = HomeViewModel.GetInstance();
                        break;

                    case ViewType.Setting:
                        this.ActiveItem = SettingViewModel.GetInstance();
                        break;

                    default:
                        throw new Exception("View not found");
                }
            });
        }

        public ICommand UpdateCurrentView { get; }

    }
}
