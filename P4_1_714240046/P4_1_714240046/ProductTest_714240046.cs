using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240046
{
    class ProductTest_714240046
    {
       static void Main(string[] args)
        {
            Book_714240046 myBook = new Book_714240046("Book", "C# Object oriented solution", "380");
            DVD_714240046 mybook = new DVD_714240046("Ethernal sunshine of the spotless mind", "145");
            
            myBook.DisplayInfo();
            mybook.DisplayInfo();
        }
   }
}
