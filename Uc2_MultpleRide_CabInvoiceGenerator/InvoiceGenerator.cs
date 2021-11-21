using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc2_MultpleRide_CabInvoiceGenerator
{
   public  class InvoiceGenerator
    {

        RideType rideType;
        // constraint
        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;

        // initialize new instance of the InvoiceGenerator class
        public InvoiceGenerator(RideType rideType)
        {
            //this.rideReposetory = new RideRepository();
            this.rideType = rideType;
            try
            {
                if (this.rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }
                if (this.rideType.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_RIDETYPE, "invalide ridetype");
            }
        }
        public double Calculatefare(double distance, int time)
        {
            double totalfare = 0;
            try
            {
                totalfare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
            }
            catch (CabInvoiceException)
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_RIDETYPE, "invalide ridetype");
                }
                if (time <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.INVALIDE_RIDETYPE, "invalide ridetype");
                }
            }
            return Math.Max(totalfare, MINIMUM_FARE);

        }

        //uc2
        public double CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            //checks for rides available and pases them calculate fare method for each method
            try
            {
              // calculating total fare of aal ride
              foreach(Ride ride in rides)
                {
                    totalFare += this.Calculatefare(ride.distance, ride.time);
                }
            }
            //catches Exception
            catch(CabInvoiceException)
            {
                if (rides == null)
                {
                    throw new CabInvoiceException(CabInvoiceException.Exceptiontype.NULLRIDES, "no rides found");
                }
            }
            // return invoice sumary object
            return totalFare;
        }
    }
}
