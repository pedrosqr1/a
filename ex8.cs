using System;

namespace ex8feito
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            Console.WriteLine("nome: ");
            nome = Console.ReadLine();

            foreach(char c in nome)
            {
                Console.Write(c);
            }
            Console.WriteLine(Environment.NewLine+"FOR 0 ate N");
            for (int i = 0; i < nome.Length; i++)
            {
                char c = nome[i];
                Console.Write(c);
            }
            Console.WriteLine(Environment.NewLine+"FOR N ate 0");
            for (int i = nome.Length-1;i>=0;i--)
            {
                char c = nome[i];
                Console.Write(c);
            }
          
        }
    }
}
