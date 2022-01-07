using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartDBReader : ICart
    {
        public void DisplayCartItems()
        {
            CartList cartList = GetCartListFromTextFile();
            foreach (var item in cartList.Items)
            {
                Console.WriteLine(Utility.Columize(item.Code) + Utility.Columize(item.Name) + Utility.Columize(item.UnitsAvailable.ToString()) + Utility.Columize(item.UnitsAvailable.ToString()));
                Console.WriteLine(KeyStore.TableSeperator);
            }
        }

        private CartList GetCartListFromTextFile()
        {
            string line;
            CartList cartList = new CartList();
            try
            {
                using (StreamReader sr = new StreamReader(KeyStore.CartFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        var item = TranslateToCartItem(line);
                        cartList.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage + e.Message);
                Console.WriteLine(KeyStore.Seperator);
            }
            return cartList;
        }

        private static CartItem TranslateToCartItem(string itemString)
        {
            string[] itemDetails = itemString.Split("|");
            return new CartItem()
            {
                Code = itemDetails[0],
                Name = itemDetails[1],
                UnitsAvailable = Convert.ToInt32(itemDetails[2]),
                CostPerUnit = Convert.ToInt32(itemDetails[3])
            };
        }
    }
}
