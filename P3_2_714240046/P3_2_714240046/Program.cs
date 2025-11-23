using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;

            while (ulang)
            {
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                int menu;
                bool validInput = int.TryParse(Console.ReadLine(), out menu);

                if (!validInput)
                {
                    Console.WriteLine("Input tidak valid! Silakan masukkan angka 1-3.");
                }
                else
                {
                    switch (menu)
                    {
                        case 1:
                            Console.Write("Masukkan panjang: ");
                            double panjang1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            double lebar1 = Convert.ToDouble(Console.ReadLine());
                            double luas = panjang1 * lebar1;
                            Console.WriteLine($"Luas Persegi Panjang: {luas}");
                            break;

                        case 2:
                            Console.Write("Masukkan panjang: ");
                            double panjang2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan lebar: ");
                            double lebar2 = Convert.ToDouble(Console.ReadLine());
                            double keliling = 2 * (panjang2 + lebar2);
                            Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                            break;

                        case 3:
                            Console.WriteLine("Program selesai.");
                            Console.WriteLine("Terima kasih!");
                            return;

                        default:
                            Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                            break;
                    }
                }

                Console.Write("Ingin mengulang kembali (Y/T)? ");
                string pilihan = Console.ReadLine().ToUpper();

                if (pilihan == "T")
                {
                    Console.WriteLine("Terima kasih!");
                    ulang = false;
                }
                else if (pilihan == "Y")
                {
                    ulang = true;
                }
                else
                {
                    Console.WriteLine("Input tidak dikenali, program dihentikan.");
                    ulang = false;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
