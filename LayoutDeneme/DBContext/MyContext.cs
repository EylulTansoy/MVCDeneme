using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LayoutDeneme.DBContext
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name = MyContextConStr")
        {

        }

        public System.Data.Entity.DbSet<EFDeneme.Models.Post> Posts { get; set; }

        public System.Data.Entity.DbSet<EFDeneme.Models.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<EFDeneme.Models.Tag> Tags { get; set; }

        public System.Data.Entity.DbSet<EFDeneme.Models.User> Users { get; set; }
    }
}