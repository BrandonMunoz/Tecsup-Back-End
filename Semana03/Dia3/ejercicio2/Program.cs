using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            int n3 = Int32.Parse(Console.ReadLine());
            int MAX = calcularMax(n1, n2, n3);
            int MIN = calcularMin(n1, n2, n3);
            Console.WriteLine(MAX);
            Console.WriteLine(MIN);
        }

        public static int calcularMax(int n1,int n2 ,int n3)
        {
            int max;
            if (n1 > n2 && n1 > n3)
                max= n1;
            else if (n2 > n1 && n2 > n3)
                max= n2;
            else
                max= n3;
            return max;
        }

        public static int calcularMin(int n1, int n2, int n3)
        {
            return Math.Min.(Math.Min(n1, n2), n3);
        }
    }
}
