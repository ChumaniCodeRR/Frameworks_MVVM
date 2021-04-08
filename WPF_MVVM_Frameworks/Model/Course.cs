using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Frameworks.Model
{
    class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        public string cName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
