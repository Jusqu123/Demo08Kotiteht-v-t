using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice { Customer = "John Lennon" };


            Item item1 = new Item {Name="Glasses ",Price=399,Quantity=1};

            Item item2 = new Item {Name="Guitar ",Price=4697.80,Quantity=3};

            Item item3 = new Item {Name="Vinyls ",Price=9.99,Quantity=15};



            invoice.AddItem(item1);

            invoice.AddItem(item2);

            invoice.AddItem(item3);

            invoice.TotalPrice();

            invoice.PrintInvoice();
        }
    }
}
