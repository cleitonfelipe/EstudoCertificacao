using System;
using System.Threading;

namespace Chapter_1_Listing_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadKey();
        }
    }
}
