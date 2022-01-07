using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class InventoryService : IInventoryService
    {
        public void DisplayMenu()
        {
            Console.WriteLine(KeyStore.WelcomeMessage);
            Console.WriteLine(KeyStore.Seperator);
            Utility.DisplayMenuHeader();
            Inventory inventory = InventoryDBReader.GetInventoryFromTextFile();
            InventoryDBReader.DisplayInventory(inventory);
            Console.WriteLine(KeyStore.Seperator);
        }
    }
}
