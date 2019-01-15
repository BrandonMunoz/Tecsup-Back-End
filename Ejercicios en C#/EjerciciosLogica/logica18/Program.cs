using System;

namespace logica18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad en años y meses");
            Console.WriteLine("ingrese los años");
            int años = 0;
            años = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los meses");
            int meses = 0;
            meses = int.Parse(Console.ReadLine());
            int total = (años * 12) + meses;
            Console.WriteLine("su edad es: " + total + " meses");
            Console.ReadKey();

        }
    }
}
