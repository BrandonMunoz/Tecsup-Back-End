using System;

namespace bucle17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine(i+" "+(i*i));
                
                i++;
            }
            Console.ReadKey();
        }
    }
}
