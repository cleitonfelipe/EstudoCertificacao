using System;
using System.Threading;

namespace Chapter_1_Listing_1_6
{
    class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });
        static void Main(string[] args)
        {
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < _field.Value; x++)
                { 
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
