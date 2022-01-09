namespace SRP
{
    public class WithoutSRPStudentclass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float PaperAMarks { get; set; }
        public float PaperBMarks { get; set; }
        public float PaperCMarks { get; set; }
        public float BasicTution { get; set; }
        public float OtherFees { get; set; }

        public float CalculateMarksAverage()
        {
            return (PaperAMarks + PaperBMarks + PaperCMarks) / 3;
        }

        public float CalculateFees()
        {
            return BasicTution + OtherFees;
        }
    }
}
