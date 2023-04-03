using System;

namespace simbora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para exibir a tabuada de 0 a 9.
            int multiplicando;

            Console.WriteLine("Informe o número desejado: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 9; multiplicador++)
            {
                Console.WriteLine(string.Format("{0}*{1}={2}", multiplicando, multiplicador, multiplicando * multiplicador));
            }
        }
    }
}
