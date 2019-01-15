using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nro Notas");
            int nroNotas = Int32.Parse(Console.ReadLine());
            float Promedio= CalcularPromedio(nroNotas);
            AproboDeasprobo(promedio);
        }

        public static float CalcularPromedio(int nroNotas)
        {
            float acum = 0;
            for (int i = 1; i < nroNotas; i++)
            {
                Console.WriteLine($"Ingrese nota {i}:");
                float nota = float.Parse(Console.ReadLine());
                acum = acum + nota;
            }
            return acum/nroNotas;

        }
        
        public static void AproboDesaprobo(float promedio)
        {
            if (promedio > 10.5)
                Console.WriteLine("Aprueba");
            else
                Console.WriteLine("desaprueba");
        }
    }
}
