using System;

namespace ShoppingCart
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            Console.WriteLine(KeyStore.EnterName);
            name = Console.ReadLine();
            Console.WriteLine(KeyStore.Email);
            email = Console.ReadLine();
            IInventory inventory = new Inventory();
            inventory.DisplayMenu();
            ICart cart = new Cart();
            cart.DisplayCartItems();
        }
    }
}
