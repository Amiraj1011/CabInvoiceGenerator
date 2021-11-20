using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" WELCOME TO CAB INVOICE GENERATOR");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double toatalFare = invoiceGenerator.CaculateFare(500, 5);
            Console.WriteLine("Total Fare Of Journey : " + toatalFare);
        }
    }
}
