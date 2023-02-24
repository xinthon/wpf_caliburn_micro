using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_caliburn_micro.ViewModels
{
    internal class HomeViewModel : Screen
    {


        private static HomeViewModel? Instance;
        public static HomeViewModel GetInstance()
        {
            if(Instance == null)
            {
                Instance = new HomeViewModel();
            }

            return Instance;
        }
    }
}
