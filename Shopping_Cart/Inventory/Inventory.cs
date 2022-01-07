using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Inventory : IInventory
    {
        public void DisplayMenu()
        {
            Console.WriteLine(KeyStore.WelcomeMessage);
            Console.WriteLine(KeyStore.Seperator);
            Utility.DisplayMenuHeader();
            InventoryList inventoryList = InventoryListDBReader.GetInventoryListFromTextFile();
            InventoryListDBReader.DisplayInventoryList(inventoryList);
            Console.WriteLine(KeyStore.Seperator);
        }
    }
}
