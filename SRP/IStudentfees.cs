namespace ISRP_1
{
    public interface IStudentfees
    {
        float BasicTution { get; set; }
        float OtherFees { get; set; }

        float CalculateFees();
    }
}