using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Posts = new HashSet<Post>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
