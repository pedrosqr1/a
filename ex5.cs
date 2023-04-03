using System;

namespace maisum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            int maior;
            int menor;
            int i;
            
            Console.WriteLine("Informe o número: ");
            num = Convert.ToInt32(Console.ReadLine());
            maior = num;
            menor = num;
            i = 1;
            for (i = 2; i <= 5; i++)
            {
                Console.WriteLine("informe o numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < menor)
                {
                    menor = num;
                }
                if (num > maior)
                {
                    maior = num;
                }

            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O maior número é: " + menor);
        }
    }
}
