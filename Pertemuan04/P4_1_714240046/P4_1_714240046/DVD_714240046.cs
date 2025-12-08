using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240046
{
    public class DVD_714240046 : Product_714240046
    {
        protected string duration;

        public DVD_714240046(string title, string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, Duration);
        }
    }

}
