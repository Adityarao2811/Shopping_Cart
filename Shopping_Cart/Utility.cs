using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Utility
    {
        public static void DisplayMenu()
        {
            Console.WriteLine(KeyStore.WelcomeMessage);
            Console.WriteLine(KeyStore.Seperator);
            Utility.DisplayTable(KeyStore.MenuHeader);
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(KeyStore.InventoryFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        DisplayTable(line);
                    }
                }
                Console.WriteLine(KeyStore.Seperator);
            } catch (Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage + e.Message);
                Console.WriteLine(KeyStore.Seperator);
            }
        }

        public static void DisplayTable(string row)
        {
            string[] words = row.Split("|");
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
