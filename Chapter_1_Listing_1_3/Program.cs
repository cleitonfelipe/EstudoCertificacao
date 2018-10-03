using System;
using System.Threading;

namespace Chapter_1_Listing_1_3
{
    /// <summary>
    /// Utilizando o delegate ParameterizedThreadStart
    /// Neste código utilizo um dos overload do construtor da classe Thread que recebe uma instancia do delegate ParameterizedThreadStart
    /// Este overload auxilia em passar dados atraves do start do método da sua thread para outra thread que está em execução.
    /// </summary>
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i} + {o}");
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start("Cleiton");
            t.Join();

            Console.ReadKey();
        }
    }
}
