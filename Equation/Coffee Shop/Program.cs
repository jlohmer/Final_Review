using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drinkName = new List<string>();
            List<double> drinkCost = new List<double>();
            List<int> shotNumber = new List<int>();
            List<string> shotFlavor = new List<string>();
            List<double> shotCost = new List<double>();
            string userStart = Console.ReadLine().ToLower();
            string userChoice;
            string shotChoice;
            string shotType = string.Empty;
            string anotherDrink;
            int shotNum = 0;
            double orderPrice = 0;
            double shotTotal = 0;
            double espressoPrice = 2.15;
            double cappuccinoPrice = 4.20;
            double lattePrice = 5;
            double americanoPrice = 3.55;
            double dripPrice = 1.25;
            double drinkPrice = 0;
            if (userStart == "hello")
            {
                Console.WriteLine("     Welcome to my coffee shop!");
                Console.WriteLine("         Here is the menu.");
                Console.WriteLine();
                Console.WriteLine(" Menu Item                     Price");
                Console.WriteLine(" Espresso                      $2.15");
                Console.WriteLine(" Cappuccino                    $4.20");
                Console.WriteLine(" Latte                         $5.00");
                Console.WriteLine(" Americano                     $3.55");
                Console.WriteLine(" Drip                          $1.25");
            }
            do
            {
                Console.WriteLine("What drink would you like? (Enter as shown on menu)");
                userChoice = Console.ReadLine();
                if (userChoice == "Espresso")
                {
                    drinkPrice = espressoPrice;
                    orderPrice += espressoPrice;
                }
                else if (userChoice == "Cappuccino")
                {
                    drinkPrice = cappuccinoPrice;
                    orderPrice += cappuccinoPrice;
                }
                else if (userChoice == "Latte")
                {
                    drinkPrice = lattePrice;
                    orderPrice += lattePrice;
                }
                else if (userChoice == "Americano")
                {
                    drinkPrice = americanoPrice;
                    orderPrice += americanoPrice;
                }
                else if (userChoice == "Drip")
                {
                    drinkPrice = dripPrice;
                    orderPrice += dripPrice;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                drinkName.Add(userChoice);
                drinkCost.Add(drinkPrice);

                Console.WriteLine();
                Console.WriteLine("     Extras                    Price Increase");
                Console.WriteLine(" Shot of Vanilla              +$0.75 each shot");
                Console.WriteLine(" Shot of Espresso             +$0.80 each shot");

                Console.WriteLine("Would you like to add a shot? (Yes/Y or No/N)");
                shotChoice = Console.ReadLine();
                if (shotChoice == "Yes" || shotChoice == "Y")
                {
                    Console.WriteLine("Which shot type would you want? (Vanilla or Espresso)");
                    shotType = Console.ReadLine();
                    Console.WriteLine("How many shots do you want?");
                    shotNum = Convert.ToInt32(Console.ReadLine());
                }
                if (shotType == "Vanilla")
                {
                    shotTotal = shotNum * .75;
                    orderPrice = orderPrice + shotTotal;
                }
                if (shotType == "Espresso")
                {
                    shotTotal = shotNum * .8;
                    orderPrice = orderPrice + shotTotal;
                }
                shotFlavor.Add(shotType);
                shotNumber.Add(shotNum);
                shotCost.Add(shotTotal);

                Console.WriteLine("Would you like to order another drink? (Y/N)");
                anotherDrink = Console.ReadLine().ToUpper();
            } while (anotherDrink == "Y");

            var drinkorders = drinkName.Zip(drinkCost, (n, c) => new { drinkName = n, drinkCost = c });
            foreach (var nc in drinkorders)
            {
                Console.WriteLine($"{nc.drinkName}: {nc.drinkCost}");
            }

            var shotorders = shotFlavor.Zip(shotCost, (f, c) => new { shotFlavor = f, shotCost = c });
            foreach (var fc in shotorders)
            {
                Console.WriteLine($"{fc.shotFlavor}: {fc.shotCost}");
            }
            Console.WriteLine($"Order Total: {orderPrice}");

            Console.ReadKey();
        }
    }
}
