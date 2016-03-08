using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace Shopping
{
    [Serializable]
    class Invoice
    {
        public string customerName { get; set; }
        private double total { get; set; }
        List<Item> items;

        public Invoice()
        {
            items = new List<Item>();
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public void showInvoice()
        {
            Console.WriteLine("Customer {0} invoice:", customerName);
            Console.WriteLine("==================");
            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
                total += item.total();
            }
            Console.WriteLine("==================");
            Console.WriteLine("Total = {0} Euros", total);
   
        }
    }
}
