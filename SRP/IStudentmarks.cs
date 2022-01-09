namespace ISRP_2
{
    public interface IStudentmarks
    {
        float PaperAMarks { get; set; }
        float PaperBMarks { get; set; }
        float PaperCMarks { get; set; }

        float CalculateMarksAverage();
    }
}