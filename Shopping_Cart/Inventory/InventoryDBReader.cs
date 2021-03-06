using System;
using System.IO;

namespace ShoppingCart
{
    public static class InventoryDBReader
    {
        public static void DisplayInventory(Inventory inventory)
        {
            foreach (var item in inventory.Items)
            {
                Console.WriteLine(Utility.Columize(item.Code) + Utility.Columize(item.Name) + Utility.Columize(item.UnitsAvailable.ToString()) + Utility.Columize(item.CostPerUnit.ToString()));
                Console.WriteLine(KeyStore.TableSeperator);
            }
        }

        public static Inventory GetInventoryFromTextFile()
        {
            string line;
            Inventory inventory = new Inventory();
            try
            {
                using (StreamReader sr = new StreamReader(KeyStore.InventoryFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        var item = TranslateToInventoryItem(line);
                        inventory.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage + e.Message);
                Console.WriteLine(KeyStore.Seperator);
            }
            return inventory;
        }

        private static InventoryItem TranslateToInventoryItem(string itemString)
        {
            string[] itemDetails = itemString.Split("|");
            return new InventoryItem()
            {
                Code = itemDetails[0],
                Name = itemDetails[1],
                UnitsAvailable = Convert.ToInt32(itemDetails[2]),
                CostPerUnit = Convert.ToInt32(itemDetails[3])
            };
        }

    }
}
