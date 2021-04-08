using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Frameworks.Model
{
    class PersonnelBusinessObject
    {
        List<User> Employee { get; set; }

        public PersonnelBusinessObject()
        {
            //Employee = data
        }
    }
}
