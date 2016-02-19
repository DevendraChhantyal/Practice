namespace Deven.Web.Application123.Migrations
{
    using Deven.Web.Application123.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Deven.Web.Application123.Context.AppDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Deven.Web.Application123.Context.AppDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Course> cList = new List<Course>()
            {
                new Course()
                {
                    Name="Asp.Net with MVC",
                    Description="Asp.Net with MVC",
                    Fees=20000,
                    Duration=4,
                    DurationType="MONTHS",
                    Status=true
                },
                new Course()
                {
                    Name="Python with Django Framework",
                    Description="Python with Django Framework",
                    Fees=15000,
                    Duration=10,
                    DurationType="WEEKS",
                    Status=true
                },
                new Course()
                {
                     Name="Advance SQL",
                    Description="Advance SQL",
                    Fees=10000,
                    Duration=2,
                    DurationType="MONTHS",
                    Status=false
                }
            };
            cList.ForEach(c =>
            {
                context.Courses.Add(c);
                context.SaveChanges();
            });
        }
    }
}
