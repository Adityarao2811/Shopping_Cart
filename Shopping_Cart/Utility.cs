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
            Console.WriteLine(KeyStore.MenuHeader);
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(KeyStore.InventoryFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine(KeyStore.Seperator);
            }catch(Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage+e);
                Console.WriteLine(KeyStore.Seperator);
            }                     
        }
    }
}
