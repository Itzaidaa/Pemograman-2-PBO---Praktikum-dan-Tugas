using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_P4_2_714240046
{
    public abstract class Service_NPM
    {
        
        private string name;
        private decimal price;

        
        protected Service_NPM(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        
        public string Name
        {
            get { return name; }
            set { name = value ?? "Unnamed"; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value < 0 ? 0 : value; }
        }

        
        public void ShowInfo()
        {
            Console.WriteLine($"[Layanan] {Name} | Harga: {Price:C}");
        }

        
        public abstract void Describe();
    }
}
