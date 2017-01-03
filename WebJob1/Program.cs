using System;
using System.Threading;

namespace WebJob1
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            Console.WriteLine("Starting....");
            while (true)
            {
                Console.WriteLine("Working....");
                Thread.Sleep(1000);
            }
        }
    }
}
