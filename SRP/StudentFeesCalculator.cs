using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISRP_1;

namespace SRP
{
    public class StudentFeesCalculator : IStudentfees
    {
        public float BasicTution { get; set; }
        public float OtherFees { get; set; }
        public float CalculateFees()
        {
            return BasicTution + OtherFees;
        }
    }
}
