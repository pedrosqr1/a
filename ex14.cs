using System;

namespace ex6fazendo
{
    class Program
    {
        static void Main(string[] args)
        {
            //14) Faça um algoritmo que converta uma velocidade expressa em km/ h para m/ se vice versa. Você
            //deve criar um menu com as duas opções de conversão e com uma opção para finalizar o programa.
            //O usuário poderá fazer quantas conversões desejar, sendo que o programa será finalizado quando
            //a opção de finalizar for escolhida

            int conv;
            float km;
            float ms;                  
            do
            {
                Console.WriteLine("Para converter km/h para m/s, digite 1. Para converter m/s para km/h, digite 2 ");
                conv = Convert.ToInt32(Console.ReadLine());

                if (conv == 1)
                {
                    Console.WriteLine("Digite a velocidade em km/h: (digite 0 para encerrar).");
                    km = Convert.ToSingle(Console.ReadLine());
                    if (km == 0)
                        break;
                    

                    Console.WriteLine($"Velocidade em m/s: {km / 3.6}");

                }
                else
                {
                    Console.WriteLine("Digite a velocidade em m/s: (digite 0 para encerrar) ");
                    ms = Convert.ToSingle(Console.ReadLine());
                    if (ms == 0)
                        break;
                    Console.WriteLine($"Velocidade em km/h: {ms * 3.6}");
                }
            } while (true);
        }
    }
}
