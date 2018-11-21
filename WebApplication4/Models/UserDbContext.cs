using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class UserDbContext : DbContext
    {
        public DbSet<Users> Users
        {
            get;
            set;
        }
        public UserDbContext()
            //Reference the name of your connection string ( WebAppCon ) 
            : base("Parlon") { }

        public System.Data.Entity.DbSet<WebApplication4.Models.Posts> Posts { get; set; }
    }
}