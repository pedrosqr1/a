using System;

namespace ex12temtadp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            int num = 0;
            while(num<100)
            {
                num += 1;
                Console.WriteLine(num);
            }

            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;

            } while (a <=100);
        }
    }
}
