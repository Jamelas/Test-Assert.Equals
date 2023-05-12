using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLibrary
{
    public class ParkingCalculator
    {
        private const double StaffCharge = 30;
        private const double StudentDiscount = 0.25;
        private const double GeneralCharge = 5;

        public double CalculateParkingCharge(PersonType myPersonType, int hours)
        {
            if (myPersonType == PersonType.Staff)
            {
                return StaffCharge;
            }
            else if (myPersonType == PersonType.General)
            {
                return hours * GeneralCharge;
            }
            else if (myPersonType == PersonType.Student)
            {
                return hours * GeneralCharge * (1 - StudentDiscount);
            }
            else
            {
                return 0;
            }
        }
    }
}
