using DIP;
using System;

namespace _WithDIP
{
    public class WithDIP
    {
        IEmployeeDataAccess _EmployeeDataAccess;

        public WithDIP()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
