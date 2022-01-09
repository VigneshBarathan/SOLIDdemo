using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    #region "Commented the tightly coupled code-DIP"
    //public class EmployeeDataAccess
    //{
    //    public Employee GetEmployeeDetails(int id)
    //    {
    //        Employee emp = new Employee()
    //        {
    //            ID = id,
    //            Name = "Vicky",
    //            Department = "IT",
    //            Salary = 100000
    //        };
    //        return emp;
    //    }


    //} 
    #endregion

    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }


}
