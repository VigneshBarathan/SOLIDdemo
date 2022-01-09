using System;

namespace _WithOCP
{
    /// <summary>
    /// WithOCPInvoice - Here the GetInvoiceDiscount will not be changed in future even if we have one more invoice type
    /// Hence OCP is followed successfully --> Closed for modification and Opened for extension
    /// </summary>
    public class WithOCPInvoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }

    }

    public class FinalInvoice : WithOCPInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : WithOCPInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : WithOCPInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
