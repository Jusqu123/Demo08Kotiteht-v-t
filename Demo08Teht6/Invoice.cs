using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Teht6
{
    public class Invoice
    {


        public string Customer { get; set; }

        public double Total { get; set; }

        private List<Item> Items { get; }



        public Invoice()

        {
            Items = new List<Item>();
        }



        public void AddItem(Item item)

        {
            Items.Add(item);
        }



        public double TotalPrice()

        {
            double total = 0;


            foreach (Item itm in Items)

            {
                total = total + (itm.Quantity * itm.Price);
            }
            Total = total;

            return Total;
        }

        public void PrintInvoice()
        {

            string eItem = "  ";

            foreach (Item item in Items)
            {
                eItem +="\n"+ item.ToString();



            }

            Console.WriteLine("Customer " + Customer+ "'s invoice");

            Console.WriteLine("===================================================");

            Console.WriteLine(eItem );

            Console.WriteLine("===================================================");

            Console.WriteLine("Full Price: " + Total + "euros");
        }
        }
        }