using System;

namespace EjerciciosBackEnd_If_Else_o_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            Console.WriteLine("Ingrese un numero del 1 al 5");
            n1 = Convert.ToInt32(Console.ReadLine());

            int conteo = 0;

            for (int n=1;n<=n1;n++)
            {
                if (n1 % n ==0)
                {
                    conteo = conteo + 1;
                }

            }

            if (conteo==2)
            {

                Console.WriteLine("Es primo");

            }
            else
            {
                Console.WriteLine("no es primo");
            }


            Console.ReadKey();
            
            
        }
    }
}
