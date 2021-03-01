using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Payment
    {
        private FoodItem[] FI = new FoodItem[100];
        private DrinkItem[] DI = new DrinkItem[100];
        private int FICount;
        private int DICount;

        public Payment()
        {
            FICount = 0;
            DICount = 0;
        }

        public void AddFoodItem(FoodItem food)
        {
            if (FICount <= FI.Length)
            {
                FI[FICount] = food;
                FICount++;
            }
        }

        public void AddDrinkItem(DrinkItem drink)
        {
            if (DICount <= DI.Length)
            {
                DI[DICount] = drink;
                DICount++;
            }
        }

        public FoodItem GetFood(int i)
        {
            return FI[i];
        }

        public DrinkItem GetDrink(int i)
        {
            return DI[i];
        }



        public double FindPrice(Item[] productlist, string code)
        {
            for(int i = 0; i < productlist.Length; i++)
            {
                if(productlist[i] != null && productlist[i].GetCode() == code)
                {
                    return productlist[i].GetPrice();
                }
            }
            return 0;
        }



        public double CalculateBill(Item[] productlist)
        {
            double total = 0;


            for(int i = 0; i < FI.Length; i++)
            {
                if (FI[i] != null)
                {
                    double price = FindPrice(productlist, FI[i].GetCode());
                    int quantity = FI[i].GetQuantity();

                    total = total + price * quantity;
                }
            }

            for (int i = 0; i < DI.Length; i++)
            {
                if (DI[i] != null)
                {
                    double price = FindPrice(productlist, DI[i].GetCode());
                    int quantity = DI[i].GetQuantity();

                    total = total + price * quantity;
                }
            }
            return total;
        }


    }
}
