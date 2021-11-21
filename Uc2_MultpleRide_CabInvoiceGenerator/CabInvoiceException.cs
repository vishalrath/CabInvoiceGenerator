using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc2_MultpleRide_CabInvoiceGenerator
{
    class CabInvoiceException:Exception
    {

        public Exceptiontype type;
        public CabInvoiceException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
        public enum Exceptiontype
        {
            INVALIDE_DISTANCE, INVALIDE_TIME, NULLRIDES, INVALID_USER_ID, INVALIDE_RIDETYPE
        }
    }
}
