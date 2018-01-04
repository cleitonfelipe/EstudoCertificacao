using System;
using System.Threading;

namespace Chapter_1_Listing_1_1
{
    /// <summary>
    /// Criando uma thread básica com a classe Thread:
    /// Este código apresenta uma classe Program que roda um método em outra thread.
    /// A aplicação console sincroniza a uso da saida em tela para apresentar o resultado de cada thread
    /// o mecanismo da thread certifica que a segunda thread não executa uma espeficia parte ao mesmo tempo que a thread principal.
    /// </summary>
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: Do some work");
                Thread.Sleep(0);
            }

            t.Join();

            //Console.ReadKey();
        }
    }
}
