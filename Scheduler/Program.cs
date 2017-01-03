using System;
using System.Threading;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey from scheduler");
            while (true)
            {
                Console.WriteLine("I am working...");
                Thread.Sleep(1000);
            }
        }
    }
}
