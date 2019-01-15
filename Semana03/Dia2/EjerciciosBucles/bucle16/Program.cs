using System;

namespace bucle16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int i = 0;

            Console.WriteLine("lista de impares");
            while (i <= n)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
                
                i++;
            }

            Console.WriteLine("");

            Console.WriteLine("lista de pares");
            i = 0;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
                
                
            }
            Console.ReadKey();
        }
    }
}
