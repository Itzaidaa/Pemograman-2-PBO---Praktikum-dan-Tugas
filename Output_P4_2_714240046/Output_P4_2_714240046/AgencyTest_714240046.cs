using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_P4_2_714240046
{
    internal class AgencyTest_NPM
    {
        static void Main(string[] args)
        {
            Service_NPM tripRenaissance = new TimeTrip_NPM(
                name: "Renaissance Experience", price: 15000000m, yearDestination: 1503, roundTrip: true);

            Service_NPM tripFuture = new TimeTrip_NPM(
                name: "Neo Tokyo 2077", price: 20000000m, yearDestination: 2077, roundTrip: false);

            Service_NPM coinMing = new ChronoSouvenir_NPM(
                name: "Koin Emas Dinasti Ming", price: 750000m, eraTag: "Dinasti Ming", isTimeSafe: true);

            Service_NPM usb2099 = new ChronoSouvenir_NPM(
                name: "USB 16TB (2099 Prototype)", price: 1250000m, eraTag: "Cyberpunk 2099", isTimeSafe: false);

            Service_NPM[] catalog = { tripRenaissance, tripFuture, coinMing, usb2099 };

            Console.WriteLine("=== Time Travel Agency — Katalog Layanan ===\n");
            foreach (var svc in catalog)
            {
                svc.ShowInfo();
                svc.Describe();
                Console.WriteLine();
            }

            Console.WriteLine("Selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}
