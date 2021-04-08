using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Frameworks.Model
{
    class Address
    {
        public int AddressId { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}
