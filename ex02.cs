using System;

namespace tentando
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int NumParAtual = 1;
            int NumImparAtual = 1;
            Console.WriteLine("entre com o valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0 ; i<N;i++)
            {
                Console.WriteLine(NumParAtual + " -impar");
                NumParAtual += 2;
            
            }
            for (int i=0;i<N;i++)
            {
                Console.WriteLine(NumImparAtual + " -par");
                NumImparAtual += 2;
            }
        }
    }
}
