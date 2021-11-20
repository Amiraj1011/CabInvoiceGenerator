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
            double totalFare = invoiceGenerator.CaculateFare(distance, time);
            
            //Assert
            Assert.AreEqual(expected, totalFare);
        }
    }
}
