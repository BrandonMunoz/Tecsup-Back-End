using System;

namespace logica10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad para calcular");
            double edad = 0;
            edad = double.Parse(Console.ReadLine());
            double pulso = (220 - edad) / 10;
            Console.WriteLine(pulso);
            Console.ReadKey();
        }
    }
}
