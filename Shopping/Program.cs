using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shopping
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Item beer = new Item { Name = "Beer", Price = 1, Quantity = 6 };
            Item banana = new Item { Name = "Banana", Price = 5, Quantity = 3 };
            Item milk = new Item { Name = "Milk", Price = 1.5, Quantity = 1 };
            Invoice elmu = new Invoice { customerName = "Elmu" };

            elmu.addItem(beer);
            elmu.addItem(banana);
            elmu.addItem(milk);

            elmu.showInvoice();

            Stream writeStream = new FileStream("Shoppers.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, elmu);
            writeStream.Close();

            IFormatter loadFormatter = new BinaryFormatter();

            Stream readStream = new FileStream("Shoppers.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Invoice loadedElmu = (Invoice) loadFormatter.Deserialize(readStream);

            loadedElmu.showInvoice();
        }
    }
}
