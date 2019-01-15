using System;

namespace bucle1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int prom = 0;

            for (int i = 0; i< 7; i++)
            {
                Console.WriteLine("ingrese nota " +
                    "" + (i + 1));
                n = Int32.Parse(Console.ReadLine());
                prom = prom + n;
                
            }
            Console.WriteLine("el promedio es " + (prom/7));
            Console.ReadKey();
            
            
        }
    }
}
