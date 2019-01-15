using System;

namespace bucle4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for(int i=0; i<20; i++)
            {
                Console.WriteLine("ingrese numero: " + (i + 1));
                n = Int32.Parse(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine("el numero es positivo");
                }
                else
                {
                    if (n < 0)
                    {
                        Console.WriteLine("el numero es negativo");
                    }
                    else
                    {
                        Console.WriteLine("el numero es neutro");
                    }
                }
                Console.ReadKey();
            }   
        }
    }
}
