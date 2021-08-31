using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //string[] names = { "vamshi", "ravindra", "sanath", "poorna" };

            //var namesOfV = names.Where(n => n.StartsWith("V"));


            //Task 2
            //Console.WriteLine("Enter the N value");
            //int n = int.Parse(Console.ReadLine());

            //int i = 0;
            //while(i<n)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
