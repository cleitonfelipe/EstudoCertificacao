using System;
using System.Threading.Tasks;

namespace Chapter_1_Listing_1_8
{
    /// <summary>
    /// Criando uma task e executando imediatamente
    /// Nesta Task é executado um for de 0 á 100 printando um * na linha.
    /// Crio a variavel "t" do tipo Task e atribuo uma task em execução a ela
    /// e em seguida chamo o método Wait para aguardar o termino da execução para seguir em frente a aplicação
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();
            Console.ReadKey();
        }
    }
}
