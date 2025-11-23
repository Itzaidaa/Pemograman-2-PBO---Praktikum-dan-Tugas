using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240046
{
    public class Book_714240046 : Product_714240046
    {
        protected String pageCount;

        public Book_714240046(string type, string title, string pageCount) : base(type, title)
        {
            this.pageCount = pageCount;
        }

        public string PageCount
        {
            get { return this.pageCount; }
            set { pageCount = value; }
        }

        public override void DisplayInfo()
        {

            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);

        }
    }
}
