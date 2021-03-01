﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class FoodItem
    {
        private string ItemCode;
        private int Quantity;

        public FoodItem(string itemcode, int quantity)
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
