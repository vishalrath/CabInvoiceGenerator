using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uc3_Enhance_CabInvoicegenerator;

namespace MSTestCabInvoiceGeneratore
{
    [TestClass]
    public class CabInvoiceTestClass
    {

        // ger total fare one trip uc1
        [TestMethod]
        public void GiveDistanceAndTimeShouldRetuenTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double expected = 25;
            double distance = 2.0;
            int time = 5;

            //calculateFare
            double fare = invoice.Calculatefare(distance, time);

            Assert.AreEqual(expected, fare);

        }
        //uc2 given the multiple ride should return invoice summary
        //[TestMethod]
        //[TestCategory("fare")]
        //public void GivenMultipleRidesShouldReturnTotalFare()
        //{
        //    double expected = 60;
        //    //  creating instance of invoice generator
        //    InvoiceGenerator obj = new InvoiceGenerator(RideType.PREMIUM);
        //    Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
        //    // generating summary of all rides
        //    double actual = obj.CalculateFare(rides);

        //    Assert.AreEqual(actual, expected);
        //}
        [TestMethod]
        [TestCategory("fare")]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
           // double expected = 60;
            //  creating instance of invoice generator
            InvoiceGenerator obj = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary expected = new InvoiceSummary(rides.Length, 30);
            // generating summary of all rides
            InvoiceSummary actual = obj.CalculateFare(rides);

            //actual.Equals(expected);
            Assert.AreEqual(actual, expected);
        }
    }


}
