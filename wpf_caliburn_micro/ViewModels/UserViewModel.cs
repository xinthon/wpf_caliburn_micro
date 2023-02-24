using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_caliburn_micro.ViewModels
{
    internal class UserViewModel : Screen
    {
        public UserViewModel()
        {

        }

        private static UserViewModel Instance;
        public static UserViewModel GetInstance()
        {
            if (Instance == null)
            {
                Instance = new UserViewModel();
            }

            return Instance;
        }
    }
}
