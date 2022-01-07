using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartService : ICartService
    {
        public void DisplayCartItems()
        {
            Console.WriteLine(KeyStore.DisplayingCartMessage);
            Console.WriteLine(KeyStore.Seperator);
            Utility.DisplayMenuHeader();
            Console.WriteLine(KeyStore.Seperator);
            Cart cart = CartDBReader.GetCartFromTextFile();
            foreach (var item in cart.Items)
            {
                Console.WriteLine(Utility.Columize(item.Code) + Utility.Columize(item.Name) + Utility.Columize(item.UnitsPurchased.ToString()) + Utility.Columize(item.TotalCost.ToString()));
                Console.WriteLine(KeyStore.TableSeperator);
            }
        }
    }
}
