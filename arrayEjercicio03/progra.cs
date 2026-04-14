using System;

namespace GulaArreglos
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
        //EJERCICIO DE PRACTICA 1
            int[] edades = { 15, 22, 30, 18, 25 };
            int sumaEdades = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                sumaEdades += edades[i];
            }

            Console.WriteLine("La suma de todas las edades es: " + sumaEdades);
            Console.ReadLine();
        
        //EJERCICIO DE PRACTICA 2
            int[] edades = { 15, 22, 30, 18, 25 };
            int edadMaxima = edades[0];

            for (int i = 1; i < edades.Length; i++)
            {
                if (edades[i] > edadMaxima)
                {
                    edadMaxima = edades[i];
                }
            }

            Console.WriteLine("La edad máxima es: " + edadMaxima);
            Console.ReadLine();
        //EJERCICIO DE PRACTICA 3

            int[] edades = { 15, 22, 30, 18, 25 };
            int contadorMayores18 = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    contadorMayores18++;
                }
            }

            Console.WriteLine("Cantidad de edades mayores o iguales a 18: " + contadorMayores18);
            Console.ReadLine();

    //EJERCICIO DE PRACTICA 4

         int[] edades = { 15, 22, 30, 18, 25 };
            int sumaEdades = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                sumaEdades += edades[i];
            }

            double promedioEdades = (double)sumaEdades / edades.Length;
            Console.WriteLine("El promedio de las edades es: " + promedioEdades);
            Console.ReadLine();

    //EJERCICODE PRACTICA 5

          int[] edades = { 15, 22, 30, 18, 25 };

            Console.WriteLine("Edades en orden inverso:");
            for (int i = edades.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Índice " + i + ": " + edades[i]);
            }
            Console.ReadLine();
        }

    





        


        
    }
}