using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el exponencial");
            int e = int.Parse(Console.ReadLine());
            int p = potencia(n, e);
            Console.WriteLine("el resultado es:");
            Console.WriteLine(p);
        }

        static int potencia(int n, int e)
        {
            int x = 0;
            for (int i = 1; i < e; i++)
            {
                x = x * n;
                return x;
            }

        }
    }
}
