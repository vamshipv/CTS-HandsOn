using System;
using System.Threading;

namespace ThreadStartSample
{
    public class Printer
    {
        public void PrintNumbers()
        {
            // Display Thread info.
            Console.WriteLine("-> {0} is executing PrintNumbers()",Thread.CurrentThread.Name);
            // Print out numbers.

            Console.Write("Your numbers: "); 
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i); 
                Thread.Sleep(2000);

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** Thread start Delage App****\n");
            Console.WriteLine("Do you want [1] or [2] threads");
            string threadCount = Console.ReadLine();

            Thread primanyThread = Thread.CurrentThread;
            primanyThread.Name = "Primary";

            Console.WriteLine("-> {0} is running in Main()",Thread.CurrentThread.Name);
            var p = new Printer();

            switch(threadCount)
            {
                case "2":
                    Thread backgrounndThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgrounndThread.Name = "Secondary";
                    backgrounndThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("Default thread running Thread 1");
                    goto case "1";
            }
            Console.WriteLine("Hello from the Main");
        }
    }
}
