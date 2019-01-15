using System;

namespace logica12y13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el presupuesto");
            double p = 0;
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("las siguientes areas reciben la siguiente cantidad");
            double g = p * 0.4;
            Console.WriteLine("Ginecologia " + g + " soles");
            double t = p * 0.3;
            Console.WriteLine("Traumatologia " + t + " soles");
            double pe = p * 0.3;
            Console.WriteLine("Pediatria " + pe + " soles");
            Console.ReadKey();
        }
    }
}
