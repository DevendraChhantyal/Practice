using ClassworkApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ClassworkApplication.LeapfrogDbContext
{
    public class LeapfrogDbContext : DbContext
    {
        public  LeapfrogDbContext() : base("UserDbContext")
        {

        }
            public DbSet<Course> Courses {get; set;}
            public DbSet<User> Users {get; set;}

            public DbSet<Student> Students {get; set;}
    }

}



