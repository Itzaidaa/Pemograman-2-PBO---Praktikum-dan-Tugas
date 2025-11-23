using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_714240046
{
    internal class abstraction
    {
    }

    public abstract class ParkingCalculator
    {
        public abstract int CalculateParkingFee(int hours);
    }

    public class SimpleParkingCalculator : ParkingCalculator
    {
        public override int CalculateParkingFee(int hours)
        {
            int ratePerHours = 2000;
            return hours * ratePerHours;
        }
    }
    
}
