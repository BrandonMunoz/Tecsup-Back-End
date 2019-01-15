using System;

namespace eL5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de hombres");
            double nh=0;
            nh = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de mujeres");
            double nm = 0;
            nm = double.Parse(Console.ReadLine());
            double to = nh + nm;
            double ph = (nh * 100) / to;
            double pm = (nm * 100) / to;
            Console.WriteLine("el porcentaje de hombres es: " + ph);
            Console.WriteLine("el porcentaje de mujeres es: " + pm);
            Console.ReadKey();
        }
    }
}
