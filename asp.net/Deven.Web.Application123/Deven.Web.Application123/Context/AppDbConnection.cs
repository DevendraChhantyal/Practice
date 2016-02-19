using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Context
{
    public class AppDbConnection : DbContext
    {
        public AppDbConnection()
            : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
}