using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf_caliburn_micro.ViewModels.Commands;

namespace wpf_caliburn_micro.ViewModels
{
    internal class SettingViewModel : Conductor<object>
    {
        private static SettingViewModel? Instance;
        
        public static SettingViewModel GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SettingViewModel();
            }

            return Instance;
        }


        public SettingViewModel()
        {
            ShowUserPage = new RelayCommand((object? param) =>
            {
                ActiveItem = new UserViewModel();
            });

            ShowRolePage = new RelayCommand((object? param) =>
            {
                ActiveItem = new RoleViewModel();
            });


            ActiveItem = new UserViewModel();
        }

        //private object childPage { get; set; }

        //public object ChildPage
        //{
        //    get => childPage;
        //    set {
        //        childPage = value;
        //        NotifyOfPropertyChange(() => ChildPage);
        //    }
        //}

        public ICommand ShowUserPage { get; }
        public ICommand ShowRolePage { get; }
    }
}
