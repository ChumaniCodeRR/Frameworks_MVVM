


namespace WPF_MVVM_Frameworks.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WPF_MVVM_Frameworks.Model;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using WPF_MVVM_Frameworks.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<WPF_MVVM_Frameworks.Data.MiniDbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WPF_MVVM_Frameworks.Data.MiniDbContext context)
        {
            context.Students.AddOrUpdate(s => s.StudentId,
                new Student
                {
                    sFirstName = "Marko",
                    sLastName = "marko",
                    Address = new Address { Address1 = "Ulic 1", City = "Grad 1", Country = "Zem 1" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "IT enthic"
                        },
                        new Course
                        {
                            cName = "Development"
                        }
                    }
                },
                new Student
                {
                    sFirstName = "Nikola",
                    sLastName = "Nikolic",
                    Address = new Address { Address1 = "Ulica 2", City = "Grad 2", Country = "Zemlja 2" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "IT Admin"
                        },
                        new Course
                        {
                            cName = "IT Database"
                        }
                    }
                },
                new Student
                {
                    sFirstName = "Margia",
                    sLastName = "Markov",
                    Address = new Address { Address1 = "Uli 3" , City = "Grad 3" , Country = "South Africa" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "Project"
                        },
                        new Course
                        {
                            cName = "Technical"
                        },
                        new Course
                        {
                            cName = "System IT"
                        }
                    }

                });

           // base.Seed(context);
        }
    }
}
