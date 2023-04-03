using System;

namespace borabora
{
    class Program
    {
        static void Main(string[] args)
        {
            //7) Solicitar um número entre 1 e 4. Se a pessoa digitar um número diferente, mostrar a mensagem 
            //"entrada inválida" e solicitar o número novamente.Se digitar correto mostrar o número digitado
            int num;
            Console.WriteLine("Insira um número entre 1 e 4: ");
            num = Convert.ToInt32(Console.ReadLine());
            while ((num<1)||(num>4))
            {
                Console.WriteLine("Entrada inválida. Insira um número entre 1 e 4: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            
            
                Console.WriteLine($"Número Digitado: {num}");
            
        }
    }
}
