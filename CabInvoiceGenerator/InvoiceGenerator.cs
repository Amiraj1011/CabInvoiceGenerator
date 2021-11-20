using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        //constants
        private double MINIMUM_COST_PER_KM = 10;
        private int COST_PER_TIME = 1;
        private  double MINIMUM_FARE = 5;

        //this method for calculate total fare of journey
        public double CaculateFare(double distance, int time)
        {
            double totalFare = 0;
            
            try
            {
                //calculating total fare
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
            }
            catch (CabInvoiceException)
            {             
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                }

            }
            return Math.Max(totalFare, MINIMUM_FARE);

        }

    }
}
