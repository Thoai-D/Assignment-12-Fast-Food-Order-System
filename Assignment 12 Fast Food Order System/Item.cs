using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Item
    {
        private string ItemCode;
        private string ItemName;
        private double Price;

        public Item(string itemcode, string itemname, double price)
        {
            ItemCode = itemcode;
            ItemName = itemname;
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }

        public string GetCode()
        {
            return ItemCode;
        }

        public string GetName()
        {
            return ItemName;
        }
    }
}
