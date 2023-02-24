using Caliburn.Micro;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_caliburn_micro.Core.Data;
using wpf_caliburn_micro.Core.Models;

namespace wpf_caliburn_micro.ViewModels
{
    internal class UserViewModel : Screen
    {
        private readonly DataContext dbContext;

        public UserViewModel()
        {
            dbContext = new DataContext();

            Task.Run(async () =>
            {
                Users = new ObservableCollection<User>( await dbContext.Users.ToListAsync());
            });
        }

        private ObservableCollection<User> user { get; set; }
        public ObservableCollection<User> Users { 
            get => user;
            set
            {
                user = value;
                NotifyOfPropertyChange(() => Users);
            } 
        }

        private static UserViewModel? Instance;
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
