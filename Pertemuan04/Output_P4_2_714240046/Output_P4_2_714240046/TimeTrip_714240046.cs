using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_P4_2_714240046
{
    public class TimeTrip_NPM : Service_NPM
    {
        
        public int YearDestination { get; set; }     
        public bool RoundTrip { get; set; }          

        public TimeTrip_NPM(string name, decimal price, int yearDestination, bool roundTrip)
            : base(name, price)
        {
            YearDestination = yearDestination;
            RoundTrip = roundTrip;
        }

        
        public override void Describe()
        {
            string type = RoundTrip ? "Pulang-Pergi" : "Sekali Jalan";
            Console.WriteLine($"➡️ Trip ke tahun {YearDestination} ({type}). " +
                              $"Tips: hindari paradox dengan tidak menyapa diri sendiri 😉");
        }
    }
}
