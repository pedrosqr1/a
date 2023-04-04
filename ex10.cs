using System;

namespace ex10fazendo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i = 1;
            int notas;
            int media= 0;
            Console.WriteLine("Insira o número de alunos: ");

            num = Convert.ToInt32(Console.ReadLine());
            
            while(i<=num)
            {
                Console.WriteLine("Digite as notas dos alunos: ");
                notas = Convert.ToInt32(Console.ReadLine());
                if (i == 10)
                    break;
                i++;
                media += notas;
            }
            Console.WriteLine($"Média dos alunos: {media/num}");
        }
    }
}
