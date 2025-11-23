using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_P4_2_714240046
{
    public class ChronoSouvenir_NPM : Service_NPM
    {
        public string EraTag { get; set; }      
        public bool IsTimeSafe { get; set; }    

        public ChronoSouvenir_NPM(string name, decimal price, string eraTag, bool isTimeSafe)
            : base(name, price)
        {
            EraTag = eraTag;
            IsTimeSafe = isTimeSafe;
        }

        public override void Describe()
        {
            string safety = IsTimeSafe ? "AMAN timeline ✅" : "BERISIKO paradox ⚠️";
            Console.WriteLine($"🪙 Suvenir era: {EraTag}. Status: {safety}.");
        }
    }
}
