using System;

namespace logica4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer parcial");
            double parcial1 = 0;
            parcial1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo parcial");
            double parcial2 = 0;
            parcial2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer parcial");
            double parcial3 = 0;
            parcial3 = double.Parse(Console.ReadLine());
            double parciales = (parcial1 + parcial2 + parcial3) / 3;
            Console.WriteLine("ingrese nota examen final");
            double exfinal = 0;
            exfinal = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota trabajo final");
            double tfinal = 0;
            tfinal = double.Parse(Console.ReadLine());
            double notafinal = (parciales * 0.55) + (exfinal * 0.3) + (tfinal * 0.15);
            Console.WriteLine(notafinal);
            Console.ReadKey();
        }
    }
}
