using System;

namespace logica11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese salario anterior");
            double anterior = 0;
            anterior = double.Parse(Console.ReadLine());
            double nuevo = anterior+(anterior*0.25);
            Console.WriteLine("su nuevo salario es:" + nuevo);
            Console.ReadKey();
        }
    }
}
