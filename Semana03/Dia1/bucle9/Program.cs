using System;

namespace bucle9
{
    class Program
    {
        static void Main(string[] args)
        {
            //acumuladores
            float pesoNinios = 0;
            float pesoJovenes = 0;

            //contadores
            int contNinios = 0;
            int contJovenes = 0;

            for(int p=0; p<=20; p++)
            {
                Console.WriteLine("ingrese peso: ");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad > 0 && edad <= 12)
                {
                    pesoNinios = pesoNinios + peso;
                    contNinios = contNinios + 1;
                }
                if (edad> 12 && <= 29)
                {
                    pesoJovenes = pesoJovenes + peso;
                    contJovenes = contJovenes + 1;
                }

            }
            float 
        }
    }
}
