using System;

namespace bucle6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int media=0;
            int bajo;

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("numero " + (i + 1));
                n = int.Parse(Console.ReadLine());
                media =n/2;
                 
                
            }
            Console.WriteLine(media);
        }
    }
}
