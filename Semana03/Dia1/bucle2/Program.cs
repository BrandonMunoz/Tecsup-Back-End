using System;

namespace bucle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            double cubo=0;
            double cuarta=0;

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Ingresar el numero "+(i+1)+" :");
                n = Int32.Parse(Console.ReadLine());
                cubo = Math.Pow(n, 3);
                Console.WriteLine("el cubo es: " + cubo);
                cuarta = Math.Pow(n, 4);
                Console.WriteLine("la cuarta es: " + cuarta);
            }
            Console.ReadKey();
        }
    }
}
