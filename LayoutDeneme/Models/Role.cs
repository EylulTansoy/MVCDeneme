using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
