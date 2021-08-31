using System;
using System.Threading;

namespace MultithreadingSample
{
    public class Printer
    {
        private object lockToken = new object();
        public void PrintNumbers()
        {
            lock(lockToken)
            {
            // Display Thread info.
            Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
            // Print out numbers.

            Console.Write("Your numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(2000);

            }
            Console.WriteLine();
            }
        }
        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**Multithreading Program**\n");

            Console.WriteLine("Main thread started. ThreadID = {0}", Thread.CurrentThread.ManagedThreadId);

            var p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            // Queue the method 10 times for (int i = 0; i<10; i++)
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
           Console.WriteLine("All tasks queued"); 
            Console.ReadLine();
        }
    }
}
