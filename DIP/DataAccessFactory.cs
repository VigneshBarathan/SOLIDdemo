using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class DataAccessFactory
    {
        #region "Commented the tightly coupled code-DIP"MyRegion
        //public static EmployeeDataAccess GetEmployeeDataAccessObj()
        //{
        //    return new EmployeeDataAccess();
        //} 
        #endregion

        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
