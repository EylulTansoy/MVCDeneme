using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public DateTime createdTime { get; set; }
        public Role Role { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
    
}
