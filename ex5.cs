using System;

namespace ex5fazendo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int num;
            int maior;
            int menor;


            Console.WriteLine("digite a bosta de um numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            maior = num;
            menor = num;
            while (i < 15)
            {
                Console.WriteLine("digite a bosta de um numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < menor)
                {
                    menor = num;
                }
                if (num > maior)
                {
                    maior = num;
                }
                if (i == 15)
                    break;
                i++;

            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O maior número é: " + menor);

        }
    }
}
