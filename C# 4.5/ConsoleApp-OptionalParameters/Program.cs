using System;

namespace ConsoleApp_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Required parameters
            OrderDetails("Ajo", "Earphones", 5, false);
            //Optional Parameters
            OrderDetails("Jio", "Headset");

            Console.Read();
        }

        public static void OrderDetails(string sellerName, string productName, int quantity = 1, bool IsReturnable = true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered. It’s returnable status is {3}", quantity, productName, sellerName, IsReturnable);
        }
    }
}
