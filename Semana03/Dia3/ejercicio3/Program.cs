using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero para sacar factorial");
            int n = Int32.Parse(Console.ReadLine());
            int f = factorial(n);
            Console.WriteLine(f);

        }

        static int factorial(int n)
        {
            int f = 1;
            for (int i = 1; i < n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
