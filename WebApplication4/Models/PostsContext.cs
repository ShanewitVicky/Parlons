using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{   
    public class PostsContext:DbContext
    {
       
        public DbSet<Posts> posts {
            get;
            set;
        }

        public PostsContext():base("Parlons")
        {
            
        }
    }
}