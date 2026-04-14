using System;

namespace GuiaArreglos
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
        //EJERCICIO DE PRACTICA 1
            int[] numeros = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Lista de números usando foreach:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        //EJERCICIO DE PRACTICA2
            int[] numeros = { 5, 10, 15, 20 };
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            Console.WriteLine($"La suma total es: {suma}");

        //EJERCICIO DE PRACTICA 3

         string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };
            string frutaMasLarga = "";
            foreach (string fruta in frutas)
            {
                if (fruta.Length > frutaMasLarga.Length)
                {
                    frutaMasLarga = fruta;
                }
            }
            Console.WriteLine($"La fruta con el nombre más largo es: {frutaMasLarga}");
        //EJERCICIO DE PRACTICA 4
            string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };
            int contadorVocales = 0;
            foreach (string fruta in frutas)
            {
                foreach (char caracter in fruta.ToLower())
                {
                    if ("aeiou".Contains(caracter))
                    {
                        contadorVocales++;
                    }
                }
            }
            Console.WriteLine($"El número total de vocales en los nombres de las frutas es: {contadorVocales}");

        //EJERCICIO DE PRACTICA 5

            string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };
            Console.WriteLine("Arreglo invertido:");
            for (int i = frutas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(frutas[i]);
       }    }
    }
}