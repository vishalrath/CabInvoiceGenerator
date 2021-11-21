using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc3_Enhance_CabInvoicegenerator
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double averageFare;

        //intialize a new instance of the InvoiceSummary Class
        //intialise a total of ridestotal fare angd generat avg of all class
        public InvoiceSummary(int numberOfRides, double totalFare)  //here Enhanced Invoice
        {
            this.numberOfRides = numberOfRides; //here no of ride
            this.totalFare = totalFare;       //here tatal fare
            this.averageFare = totalFare / numberOfRides;  //here calculate avarge
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary summary = (InvoiceSummary)obj;
            return this.numberOfRides == summary.numberOfRides && this.totalFare == summary.totalFare && this.averageFare == summary.averageFare;

        }
    }
}
