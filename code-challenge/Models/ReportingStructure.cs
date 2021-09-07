using System;
using System.Collections.Generic;


namespace challenge.Models
{
    public class ReportingStructure
    {
        //The employee
        public Employee Employee {get; set;}

        //The number of reports under the employee
        public Int32 NumberOfReports { get; set; }

    }
}
