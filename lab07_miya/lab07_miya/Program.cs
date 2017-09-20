using System;
using System.Collections.Generic;

namespace lab07_miya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sample buyMe = new Sample();
           
            Inventory<string> shoppingList = new Inventory<string>();
            shoppingList.Add("wok");
            shoppingList.Add("mouthwash");
            shoppingList.Add("nailPolish");
            shoppingList.Add("cottonBalls");
            shoppingList.Add("blender");
            shoppingList.Add("boots");
            shoppingList.Add("warmSocks");
            shoppingList.Add("scarf");
            shoppingList.Add("mousse");
            shoppingList.Add("hairDye");

            foreach(string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //what is a collection initializer?

            shoppingList.Remove("wok");
            shoppingList.Remove("scarf");

            foreach(string s in shoppingList)
            {
                Console.WriteLine(s);
            }

            Inventory<Product> wishList = new Inventory<Product> { };

            Inventory<Product> secretList = new Inventory<Product>();
            secretList.Add(new Product { ShopList = Sample.HandSoap});
            secretList.Add(new Product { ShopList = Sample.ShowerHead});

            Product shavingCream = new Product();

            Console.Read();
        }
    }
}
