using System;

namespace bucle14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero");
            n = Int32.Parse(Console.ReadLine())/2;
            
            int i = 0;
            while (i <= n)
            {
               
                Console.WriteLine(i*2);
                i++;
            }
            Console.ReadKey();
        }
    }
}
