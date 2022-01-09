using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _WithoutOCP
{
    public class WithoutOCPInvoice
    {
        /// <summary>
        /// GetInvoiceDiscount - In the below method , we used if else stmnt for the invoice type. In future if there is any new
        /// type is added again we need to modify the class which violates the OCP. 
        /// As per OCP the class should not be modified but can be extended(interface/abstract)
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="invoiceType"></param>
        /// <returns></returns>
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }

        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        };
    }
}
