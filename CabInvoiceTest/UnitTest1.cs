using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
       //UC1 : Test case for checking total fare function
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //AAA method
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expected = 25;


            //Act
            double totalFare = invoiceGenerator.CalculateFare(distance, time);
            
            //Assert
            Assert.AreEqual(expected, totalFare);
        }
        //UC2 : Test case for checking total fare for multiple rides
        [TestMethod]
        public void GivenMultipleRidesShouldReturnTotalFare()
        {
            //AAA method
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            double expected = 30;

            //Act
            double totalFare = invoiceGenerator.CalculateFare(rides);

            //Assert
            Assert.AreEqual(expected, totalFare);
        }
        //UC3 : Test case for checking calculate fare function for multiple rides summary
        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            //AAA method
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
          
            //Act
            InvoiceSummary summary = invoiceGenerator.CalculateFarefor(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Assert
            Assert.AreEqual(expectedSummary, summary);
        }
    }
}
