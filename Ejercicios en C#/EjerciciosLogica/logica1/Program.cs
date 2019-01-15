using System;

namespace logica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario");
            double n = 0;
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("su ganancia  mensual es");
            double g = n * 0.02;
            double N = n + g;
            Console.WriteLine(N);
            Console.ReadKey();

        }
    }
}
