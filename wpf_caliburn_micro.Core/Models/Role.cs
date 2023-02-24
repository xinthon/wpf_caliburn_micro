using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_caliburn_micro.Core.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Role name required")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<User> Users { get; set; } = new();
    }
}
