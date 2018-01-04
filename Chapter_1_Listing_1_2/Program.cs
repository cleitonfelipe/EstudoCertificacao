using System;
using System.Threading;

namespace Chapter_1_Listing_1_2
{
    /// <summary>
    /// Usando thread em background
    /// Neste código apresento a utilização de threads em background, para trabalhar com threads
    /// é muito importante entender a diferença em threads que vão rodar em back ou foreground.
    /// </summary>
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start();

            //Console.ReadKey();
        }
    }
}
