using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_1_Listing_1_9
{
    class Program
    {
        /// <summary>
        /// Criando uma task e executando imediatamente
        /// Nesta Task é criada com o tipo de retorno que esperamos
        /// Crio a variavel "t" do tipo Task e atribuo uma task em execução a ela
        /// e em seguida exibo na tela o retorno da Task.
        /// </summary>
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                Thread.Sleep(5000);
                return 42;
            });

            Console.WriteLine(t.Result);
        }
    }
}
