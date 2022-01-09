using ISRP_1;
using ISRP_2;

namespace SRP_1
{
    public class WithSRPStudentClass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        private readonly IStudentmarks _studentMarksCalculator;
        private readonly IStudentfees _studentFeesCalculator;

        public WithSRPStudentClass(IStudentfees studentFeesCalculator, IStudentmarks studentMarksCalculator)
        {
            _studentMarksCalculator = studentMarksCalculator;
            _studentFeesCalculator = studentFeesCalculator;
        }

        public float GetMarks(float A, float B, float C)
        {
            _studentMarksCalculator.PaperAMarks = A;
            _studentMarksCalculator.PaperBMarks = B;
            _studentMarksCalculator.PaperCMarks = C;
            return _studentMarksCalculator.CalculateMarksAverage();
        }

        public float GetTution(float Basic, float Others)
        {
            _studentFeesCalculator.BasicTution = Basic;
            _studentFeesCalculator.OtherFees = Others;
            return _studentFeesCalculator.CalculateFees();
        }
    }
}
