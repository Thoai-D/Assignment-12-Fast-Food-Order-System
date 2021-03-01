using System;


namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] ProductList = new Item[]
            {
                new Item("D1", "Pepsi", 10), 
                new Item("D2", "Water", 7), 
                new Item("F1", "Ratatouille", 50), 
                new Item("F2", "Fried Rice", 25)
            };

            Payment Order1 = new Payment();

            Order1.AddFoodItem(new FoodItem("F1", 5));
            Order1.AddDrinkItem(new DrinkItem("D1", 10));

            Console.WriteLine(Order1.CalculateBill(ProductList));

            PrintMenu(ProductList);
        }
        static public void PrintMenu(Item[] productlist)
        {
            for(int i = 0; i < productlist.Length; i++)
            {
                Console.WriteLine("{0,0} {1, 10} {2, 10} {3, 15}", "Item:", productlist[i].GetName(), "Price:", productlist[i].GetPrice());
            }
        }
    }
}
