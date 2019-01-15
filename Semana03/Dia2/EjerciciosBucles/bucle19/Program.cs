using System;

namespace bucle19
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("ingrese el valor de 'm'");
            m = Int32.Parse(Console.ReadLine());

            int n;
            Console.WriteLine("ingrese el valor de 'n'");
            n = Int32.Parse(Console.ReadLine());

            int i = 0;

            while (m <= n)
            {
                Console.WriteLine(i);
                m++;

            }

            Console.Write("");

            i = 0;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
