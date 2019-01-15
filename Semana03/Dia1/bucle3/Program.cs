using System;

namespace bucle3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int p;
            
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("ingrese el numero " + (i + 1));
                n = Int32.Parse(Console.ReadLine());
                if (n >= 0) { Console.WriteLine("es positivo"); }
                
            }
            Console.ReadKey();
        }
    }
}
