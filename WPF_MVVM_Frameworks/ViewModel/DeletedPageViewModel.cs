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
    class DeletedPageViewModel
    {
        public int DeleteStudent(int StudentId)
        {
            using(var db = new MiniDbContext())
            {
                Student student = db.Students.Where(s => s.StudentId == StudentId)
                    .Include("Address")
                    .SingleOrDefault();

                db.Students.Remove(student);

                return db.SaveChanges();
            }
        }
    }
}
