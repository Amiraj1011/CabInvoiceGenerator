using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" WELCOME TO CAB INVOICE GENERATOR");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            //total fare for single drive
            double toatalFare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total Fare Of Journey for single ride : " + toatalFare);
            //total fare for multiple drive
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            double totalFare = invoiceGenerator.CalculateFare(rides);
            Console.WriteLine("Total Fare Of Journey for multiple rides : " + totalFare);
        }
    }
}
