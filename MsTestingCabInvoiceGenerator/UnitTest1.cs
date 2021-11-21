using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestingCabInvoiceGenerator
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
    }
}
