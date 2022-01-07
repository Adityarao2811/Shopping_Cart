using System;

namespace ShoppingCart
{
    public class Utility
    {
        public static void DisplayMenu()
        {
            Console.WriteLine(KeyStore.WelcomeMessage);
            Console.WriteLine(KeyStore.Seperator);
            DisplayMenuHeader();
            InventoryList inventoryList = InventoryListDBReader.GetInventoryListFromTextFile();
            InventoryListDBReader.DisplayInventoryList(inventoryList);
            Console.WriteLine(KeyStore.Seperator);
        }

        public static void DisplayMenuHeader()
        {
            string[] words = KeyStore.MenuHeader.Split("|");
            Console.WriteLine(Columize(words[0]) + Columize(words[1]) + Columize(words[2]) + Columize(words[3]));
            Console.WriteLine(KeyStore.TableSeperator);
        }

        public static string Columize(string word)
        {
            var lengthOfWord = word.Length;
            for (int i = 0; i < KeyStore.DisplayColumnWidth - lengthOfWord; i++)
            {
                word = word + " ";
            }
            return word + "|";
        }                     
    }
}
