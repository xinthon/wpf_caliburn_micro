using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_caliburn_micro.Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username required")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username required")]
        public string Password { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;

        public List<Role> Roles { get; set;} = new List<Role>();
    }
}
