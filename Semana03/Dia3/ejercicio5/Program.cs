using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba el numero entero que desee");
            int n = int.Parse(Console.ReadLine());
            int S = SumaTotal(n);
            Console.WriteLine("la sumatoria es");
            Console.WriteLine(S);
        }

        public static int SumaTotal(int n)
        {
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x = x + i;
            }
        }

    }
}
