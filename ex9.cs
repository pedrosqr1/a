using System;

namespace ex13tentando
{
    class Program
    {
        static void Main(string[] args)
        {
            //9) Escreva um aplicativo mostra todos os números ímpares de 1 até 100.
            int NumImparAtual = -1;
            for (int i = 1; i <= 50;i++)
            {
               Console.WriteLine(NumImparAtual+2);
               
               NumImparAtual += 2;
            }
        }
    }
}
