using System;

namespace e9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("ingrese el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            Console.WriteLine("ingrese el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            int n3;
            Console.WriteLine("ingrese el tercer numero");
            n3 = Convert.ToInt32(Console.ReadLine());
            var aviso = "";
            if (n3 == n1 + n2)
            {
                aviso = "es igual a la suma de los dos primeros numeros";
            }
            else
            {
                aviso = "no es igual a la suma de los dos primeros numeros";
            }
            Console.WriteLine(n3+" " + aviso);
            Console.ReadKey();
        }
    }
}
