using System;

class Ejercicio1
{
    static void Main(string[] args)
    {
   //EJERCICIO DE PRACTICA 1     
        int[] numeros = new int[] { 15, 25, 30, 5 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
//EJERCICIO DE PRACTICA 2
        Console.WriteLine("La suma de los elementos es: " + suma);

         int[] numeros = new int[] { 100, 20, 300, 45, 90 };
        int maximo = numeros.Max();

        Console.WriteLine("El valor máximo es: " + maximo);
  //EJERCICIO DE PARACTICA 3
     int[] numeros = new int[] { 1, 2, 3 };

        Array.Reverse(numeros);

        Console.Write("Arreglo invertido: ");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
 //EJERCICIO DE PRACTICA 4
  int[] numeros = new int[] { 1, 2, 2, 3, 2, 4, 2 };
        int contador = 0;
        int valorBuscado = 2;

        foreach (int numero in numeros)
        {
            if (numero == valorBuscado)
            {
                contador++;
            }
        }

        Console.WriteLine("El valor " + valorBuscado + " aparece " + contador + " veces.");

 //EJERCICIO DE PRACTICA 5    

  int[] origen = new int[] { 50, 60, 70 };
        int[] destino = new int[3];

        for (int i = 0; i < origen.Length; i++)
        {
            destino[i] = origen[i];
        }

        Console.Write("Contenido del arreglo destino: ");
        foreach (int numero in destino)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    
    }
}