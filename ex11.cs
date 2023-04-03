using System;

namespace aesf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que solicita 10 números ao usuário, através de um laço while, e ao final 
            //mostre qual destes números é o maior.

            int i = 1;
            int num;
            int maior;
            int menor;
          
            
            Console.WriteLine("digite a bosta de um numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            maior = num;
            menor = num;
            while (i<10)
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
                if (i == 10)
                    break;
                i++;
                           
            }
            
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O maior número é: " + menor);

        }
    }
}
