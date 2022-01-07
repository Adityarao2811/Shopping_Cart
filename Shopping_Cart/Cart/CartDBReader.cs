using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public static class CartDBReader
    {       
        public static Cart GetCartFromTextFile()
        {
            string line;
            Cart cart = new Cart();
            try
            {
                using (StreamReader sr = new StreamReader(KeyStore.CartFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        var item = TranslateToCartItem(line);
                        cart.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage + e.Message);
                Console.WriteLine(KeyStore.Seperator);
            }
            return cart;
        }

        private static CartItem TranslateToCartItem(string itemString)
        {
            string[] itemDetails = itemString.Split("|");
            return new CartItem()
            {
                Code = itemDetails[0],
                Name = itemDetails[1],
                UnitsPurchased = Convert.ToInt32(itemDetails[2]),
                TotalCost = Convert.ToInt32(itemDetails[3])
            };
        }
    }
}
