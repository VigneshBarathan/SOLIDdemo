using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISRP_2;

namespace SRP
{
    public class StudentMarksCalculator : IStudentmarks
    {
        public float PaperAMarks { get; set; }
        public float PaperBMarks { get; set; }
        public float PaperCMarks { get; set; }
        public float CalculateMarksAverage()
        {
            return (PaperAMarks + PaperBMarks + PaperCMarks) / 3;
        }
    }
}
