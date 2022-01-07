using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartList
    {
        public List<CartItem> Items = new List<CartItem>();
    }
    public class CartItem
    {
        public string Name;
        public string Code;
        public int UnitsPurchased;
        public int TotalCost;
    }
}
