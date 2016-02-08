using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Teht6
{
    public class Item
    {


        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }

        public override string ToString()
        {


            return "Name: " + Name + "Price: " + Price + " euros"
                +  "Quantity: " + Quantity + " Total: " +
                (Total = Quantity * Price) + " euros";
        }
    }
}