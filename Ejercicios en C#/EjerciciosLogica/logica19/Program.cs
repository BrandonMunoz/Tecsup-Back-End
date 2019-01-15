using System;

namespace logica19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque el nombre del docente");
            string name = " ";
            name = Console.ReadLine();
            Console.WriteLine("Bienvenido profesor " + name);
            Console.ReadKey();
        }
    }
}
