using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class Compensation
    {
        //Employee
        public Employee Employee { get; set; }

        //Employee salary
        public String Salary { get; set; }

        //Effective date of the salary
        public String EffectiveDate { get; set; }
    }
}
