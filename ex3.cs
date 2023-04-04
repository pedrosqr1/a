using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumEntrada = 0;
            int Produto = 1;
            do
            {

                Console.WriteLine("Entre com um número: ");
                NumEntrada = Convert.ToInt32(Console.ReadLine());

                if (NumEntrada == 0)
                    break;
                Produto *= NumEntrada;
            } while (NumEntrada != 0);
            Console.WriteLine($"Produto: {Produto}");
        }
    }
}
