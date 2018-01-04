using System;
using System.Threading;

namespace Chapter_1_Listing_1_4
{
    /// <summary>
    /// Paramdo uma thread
    /// Neste código apresento uma boa prática para finalizar uma thread
    /// </summary>
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() => {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
