using System;

namespace logica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el año en el que nacio");
            double nacimiento = 0;
            nacimiento = double.Parse(Console.ReadLine());
            double edad = 2018 - nacimiento;
            Console.WriteLine("su edad es:" + edad);
            Console.ReadKey();
        }
    }
}
