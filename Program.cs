using System;
using LSP;
using LSP_1;
using SRP;
using SRP_1;
using ISP;
using ISPFixed;
using ISP_1;
using _WithOCP;
using _WithoutOCP;
using _WithDIP;
using _WithoutDIP;
using DIP;

namespace SOLIDdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRPDemo();
            //LSPDemo();
            //ISPDemo();
            //OCPDemo();
            DIPDemo();
        }



        private static void LSPDemo()
        {
            WithoutLSPclass withoutLSPclass = new LSP.Orange();
            Console.WriteLine(withoutLSPclass.GetColor());

            WithLSPClass withLSPClass = new LSP_1.Orange();
            Console.WriteLine(withLSPClass.GetColor());
            withLSPClass = new LSP_1.Apple();
            Console.WriteLine(withLSPClass.GetColor());
            Console.ReadLine();
        }

        private static void SRPDemo()
        {
            WithoutSRPStudentclass withoutSRPStudentclass = new();
            withoutSRPStudentclass.PaperAMarks = 98.50f;
            withoutSRPStudentclass.PaperBMarks = 86.00f;
            withoutSRPStudentclass.PaperCMarks = 75.90f;

            withoutSRPStudentclass.BasicTution = 12000;
            withoutSRPStudentclass.OtherFees = 8000;

            float AvgMarks = withoutSRPStudentclass.CalculateMarksAverage();
            float Tutionfees = withoutSRPStudentclass.CalculateFees();

            Console.WriteLine($"Without SRP implemented");
            Console.WriteLine($"Total marks scored:{AvgMarks}.\r\n Tution fees:{Tutionfees}");

            WithSRPStudentClass withSRPStudentClass = new(new StudentFeesCalculator(), new StudentMarksCalculator());
            float AvgMarks1 = withSRPStudentClass.GetMarks(98.50f, 86.00f, 75.90f);
            float Tutionfees1 = withSRPStudentClass.GetTution(12000, 8000);
            Console.WriteLine($"\r\n");
            Console.WriteLine($"With SRP implemented");
            Console.WriteLine($"Total marks scored:{AvgMarks1}.\r\n Tution fees:{Tutionfees1}");

            Console.ReadLine();
        }

        private static void ISPDemo()
        {
            ISP_1.HPLaserJetPrinter hPLaserJetPrinter = new();
            hPLaserJetPrinter.Print("Test");
            hPLaserJetPrinter.Scan("Test");
            hPLaserJetPrinter.Fax("Test");
            hPLaserJetPrinter.PrintDuplex("Test");

            ISP_1.LiquidInkjetPrinter liquidInkjetPrinter = new();
            liquidInkjetPrinter.Print("Test");
            liquidInkjetPrinter.Scan("Test");
            liquidInkjetPrinter.Fax("Test");
            liquidInkjetPrinter.PrintDuplex("Test");

            ISPFixed.HPLaserJetPrinter hPLaserJetPrinter1 = new();
            hPLaserJetPrinter1.Print("Test");
            hPLaserJetPrinter1.Scan("Test");
            hPLaserJetPrinter1.Fax("Test");
            hPLaserJetPrinter1.PrintDuplex("Test");

            ISPFixed.LiquidInkjetPrinter liquidInkjetPrinter1 = new();
            liquidInkjetPrinter1.Print("Test");
            liquidInkjetPrinter1.Scan("Test");

            Console.ReadLine();

        }

        private static void OCPDemo()
        {
            WithoutOCPInvoice withoutOCPInvoice = new();
            double FinalInvoice = withoutOCPInvoice.GetInvoiceDiscount(112.45f, WithoutOCPInvoice.InvoiceType.FinalInvoice);
            double ProposedInvoice = withoutOCPInvoice.GetInvoiceDiscount(564.98f, WithoutOCPInvoice.InvoiceType.ProposedInvoice);
            Console.WriteLine("Without OCP");
            Console.WriteLine($"FinalInvoice:{FinalInvoice}\r\n ProposedInvoice:{ProposedInvoice}");

            WithOCPInvoice _FinalInvoice = new FinalInvoice();
            WithOCPInvoice _ProposedInvoice = new ProposedInvoice();
            WithOCPInvoice _RecurringInvoice = new RecurringInvoice();
            double FInvoiceAmount = _FinalInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = _ProposedInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = _RecurringInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine("\r\n");
            Console.WriteLine("Without OCP");
            Console.WriteLine($"FinalInvoice:{FInvoiceAmount}\r\n ProposedInvoice:{PInvoiceAmount}\r\nRecurringInvoice:{RInvoiceAmount}");
            Console.ReadLine();
        }

        private static void DIPDemo()
        {
            EmployeeBusinessLogic employeeBusinessLogic = new();
            Employee employee = employeeBusinessLogic.GetEmployeeDetails(746);
            Console.WriteLine("Without OCP");
            Console.WriteLine($"EmpID:{employee.ID}\r\nEmpName:{employee.Name}\r\nEmpSalary:{employee.Salary}\r\nDepartment:{employee.Department}");

            WithDIP withDIP = new();
            Employee _employee = withDIP.GetEmployeeDetails(113);
            Console.ReadLine();

        }

    }
}
