using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumEntrada = 0;
            int SomaPar = 0;
            int SomaImpar = 0;

            
            do
            {
                Console.WriteLine("Entre com um numero(inteiros positivo): ");
                NumEntrada = Convert.ToInt32(Console.ReadLine());
                //if (NumEntrada > 1000)
                //break;
                if (NumEntrada % 2 == 0)
                {
                    SomaPar += NumEntrada;
                }
                else
                {
                    SomaImpar += NumEntrada;
                }
            } while (NumEntrada <= 1000);
            Console.WriteLine($"Total Par: {SomaPar} - Total Impar: {SomaImpar}");
        }
    }
}
