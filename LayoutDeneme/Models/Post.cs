using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<Tag>();
        }
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime createdTime { get; set; }
        public bool isActive { get; set; }
        public User User { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
