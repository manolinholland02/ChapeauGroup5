using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeeUserPassword { get; set; }
        public EmployeeType employeeType { get; set; }

    }
}
