using System;

namespace ex06agora
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int idade_21 = 0;
            int idade_50 = 0;

            do
            {
                Console.WriteLine("Informe a idade: (digite -99 para encerar)");
                idade = Convert.ToInt32(Console.ReadLine());
                if ((idade < 21) && (idade>0))
                {
                    idade_21 = idade_21 + 1;
                }
                if ((idade > 50) && (idade >0))
                {
                    idade_50 = idade_50 + 1;
                }
            } while (idade != -99);
            Console.WriteLine("idade menor que 21: {0}", idade_21);
            Console.WriteLine("idade maior que 50: {0}", idade_50);
        }
    }
}
