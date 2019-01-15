using System;

namespace logica20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un valor en pies para convertir a metros");
            double valor = 0;
            valor = double.Parse(Console.ReadLine());
            double pie = 30.48*0.01;
            double resultado = valor * pie;
            Console.WriteLine(resultado + " metros");
            Console.ReadKey();
        }
    }
}
