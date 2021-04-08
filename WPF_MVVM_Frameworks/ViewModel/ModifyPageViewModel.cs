using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Frameworks.Model;
using WPF_MVVM_Frameworks.Data;
using System.Data.Entity;

namespace WPF_MVVM_Frameworks.ViewModel
{
    class ModifyPageViewModel
    {
        public int UpdateStudent(Student student, List<Course> courses)
        {
            using (var db = new MiniDbContext())
            {
                var oldStudent = db.Students
                    .Include("Courses")
                    .Include("Address")
                    .SingleOrDefault(s => s.StudentId == student.StudentId);


                foreach (var item in oldStudent.Courses.ToList())
                {
                    oldStudent.Courses.Remove(item);
                }

                db.Entry(oldStudent).CurrentValues.SetValues(student);
                db.Entry(oldStudent.Address).CurrentValues.SetValues(student.Address);

                foreach (var item in courses)
                {
                    oldStudent.Courses.Add(item);
                }

                return db.SaveChanges();
            }
        }

        public Student GetStudent(int StudentId)
        {
            using (var db = new MiniDbContext())
            {
                return db.Students
                    .Include("Courses")
                    .Include("Address")
                    .Where(s => s.StudentId == StudentId)
                    .FirstOrDefault() as Student;
            }
        }
    }
}
