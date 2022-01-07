using System.Collections.Generic;

namespace ShoppingCart
{
    public class Inventory
    {
        public List<InventoryItem> Items = new List<InventoryItem>();
    }

    public class InventoryItem
    {
        public string Name;
        public string Code;
        public int UnitsAvailable;
        public int CostPerUnit;
    }
}
