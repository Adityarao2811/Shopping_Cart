using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class KeyStore
    {
        public static string EnterName = "Enter your Name";
        public static string Email = "\nEnter your email ID";
        public static string WelcomeMessage = "\n     Welcome to Fruits4U. Thank you for Choosing to Shop with us\n";
        public static string Seperator = "*************************************************************************************";
        public static string InventoryFilePath = @"C:\Users\pc\source\repos\Shopping_Cart\Shopping_Cart\Text Files\InventoryList.txt";
        public static string ExceptionCaughtMessage = "Exception caught: ";

        public static string MenuHeader = "The menu is in the form\n" + "Item-Item_Code-Quantity-Units-Cost/Unit";
    }
}
