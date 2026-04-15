using System; 

public class Program 
{
    public static void Main(string[] args)
    {
        
        const int CANTIDAD_PERSONAS = 20;

        
        string[] nombres = new string[CANTIDAD_PERSONAS ];
        int[] edades = new int[CANTIDAD_PERSONAS ];       

        Console.WriteLine("--- REGISTRO DE PERSONAS ---");
        Console.WriteLine($"Por favor, ingrese los datos de {CANTIDAD_PERSONAS } personas.");

        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"\nPersona #{i + 1}:"); 

        
            Console.Write("Ingrese el nombre: ");
            nombres[i] = Console.ReadLine(); 

            
            Console.Write("Ingrese la edad: ");
            
            
            edades[i] = int.Parse(Console.ReadLine());
        }

        

        
        for (int i = 0; i < 21; i++)
        {
            
            if (edades[i] >= 30)
            {

                Console.WriteLine($"{nombres[i]}, tienes {edades[i]} años. ¡Puedes ingresar al baile!");
            }
            else
            {
                
                Console.WriteLine($"{nombres[i]}, tienes {edades[i]} años. Lo sentimos, debes volver a casa.");
            }
        }

        
        
        Console.ReadKey(); 
    }
}
                
         
            
