using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" WELCOME TO CAB INVOICE GENERATOR");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double toatalFare = invoiceGenerator.CaculateFare(2.0, 5);
            Console.WriteLine("Total Fare Of Journey : " + toatalFare);
        }
    }
}
