using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc3_Enhance_CabInvoicegenerator
{
   public  class Ride
    {
        public double distance;
        public int time;

        //intialize new instance of the Ride Class
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
