using System;

namespace logica7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que cantidad en soles quiere cambiar a dolares?");
            double soles = 0;
            soles = double.Parse(Console.ReadLine());
            double dolares = soles * 3.5;
            Console.WriteLine(dolares);
            Console.ReadKey();
        }
    }
}
