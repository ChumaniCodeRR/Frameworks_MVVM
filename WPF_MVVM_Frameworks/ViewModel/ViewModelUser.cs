using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Frameworks.Data;
using WPF_MVVM_Frameworks.Model;

namespace WPF_MVVM_Frameworks.ViewModel
{
    
    class ViewModelUser
    {
        PersonnelBusinessObject personnel;
        ObservableCollection<User> _Employew;

        public ViewModelUser()
        {
            personnel = new PersonnelBusinessObject();
        }

        public ObservableCollection<User> Employee
        {
            get
            {
                //_Employew = new ObservableCollection<User>(personnel)
                return _Employew;
            }
        }
    }
}
