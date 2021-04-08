using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Frameworks.Data;
using WPF_MVVM_Frameworks.Model;

namespace WPF_MVVM_Frameworks.ViewModel
{
    class AddPageViewModel
    {
        public List<Course> GetCourses()
        {
            using (var db = new MiniDbContext())
            {
                return db.Courses.Select(c => c).ToList();
            }
        }

        public int AddStudent(Student student, List<Course> courses)
        {
            using (var db = new MiniDbContext())
            {
                student.Courses = courses;
                db.Students.Add(student);

                foreach (Course course in courses)
                {
                    db.Entry(course).State = System.Data.Entity.EntityState.Unchanged;
                }

                return db.SaveChanges();
            }
        }
    }
}
