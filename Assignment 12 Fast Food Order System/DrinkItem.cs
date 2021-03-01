using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class DrinkItem
    {
        private string ItemCode;
        private int Quantity;

        public DrinkItem(string itemcode, int quantity)
        {
            ItemCode = itemcode;
            Quantity = quantity;
        }
        public string GetCode()
        {
            return ItemCode;
        }

        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
