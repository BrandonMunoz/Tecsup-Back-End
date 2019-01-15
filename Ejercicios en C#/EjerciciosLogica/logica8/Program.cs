using System;

namespace logica8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero para obtener el valor absoluto");
            double valor = double.Parse(Console.ReadLine());
            double absoluto = 0;
            if (valor<0)
            {
                absoluto = absoluto+ (valor * (-1));
            }
            else
            {
                absoluto = valor;
            }
            Console.WriteLine("su valor absoluto es:" + absoluto);
            Console.ReadKey();
        }
    }
}
