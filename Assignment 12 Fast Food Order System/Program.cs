using System;
using System.IO;

namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static public int PaymentCount = 0;
        static void Main(string[] args)
        {

            Payment[] Payments = new Payment[100];

            StreamReader FileReader = new StreamReader("Food.csv");
            string line = FileReader.ReadLine();
            Console.WriteLine(line);

            Item[] MenuItems = new Item[10];
            int count = 0;
            while((line = FileReader.ReadLine()) != null)
            {

                string[] cells = line.Split(',');
                string code = cells[0];
                string name = cells[1];
                double price = Convert.ToDouble(cells[2]);

                MenuItems[count] = new Item(code, name, price);
                count++;

            }

            PrintMenu(MenuItems);
            OrderingSystem(MenuItems, Payments);

        }     
        
        static public void PrintMenu(Item[] menu)
        {
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0,0} {1,15} {2,15}" ,menu[i].GetCode(),menu[i].GetName(), menu[i].GetPrice());
            }
        }

        static public void OrderingSystem(Item[] menu, Payment[] Payments)
        {

            Console.WriteLine("Which item would you want to order(code)? Press x to exit");
            string UserResponse = Console.ReadLine();

            for(int i = 0; i < menu.Length; i++)
            {
                if(UserResponse == menu[i].GetCode() && UserResponse.StartsWith("F"))
                {
                    bool validanswer = false;
                    int Quantity = 0;
                    while (validanswer == false)
                    {
                        Console.WriteLine("How much do you want?");
                        string QuantityResponse = Console.ReadLine();
                        if(int.TryParse(QuantityResponse, out Quantity))
                        {
                            validanswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Write a number");
                        }
                    }
                    Payments[PaymentCount].AddFoodItem(new FoodItem(UserResponse, Quantity));
                }
                else
                {
                    Console.WriteLine("Enter a valid code");
                }
            }
        }
    }
}
