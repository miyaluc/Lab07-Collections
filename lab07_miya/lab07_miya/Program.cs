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
            Console.WriteLine(buyMe);

            Console.WriteLine((int)Sample.Razor);

            List<string> shoppingList = new List<string>();
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

            shoppingList.RemoveAt(6);
            shoppingList.RemoveAt(shoppingList.IndexOf("wok"));

            foreach(string s in shoppingList)
            {
                Console.WriteLine(s);
            }

            Inventory<Product> wishList = new Inventory<Product>();
            wishList.Add(new Product { ShopList = Sample.HandSoap});
            wishList.Add(new Product { ShopList = Sample.ShowerHead});

            Console.Read();
        }
    }
}
