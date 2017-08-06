using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }

    }
}
