class Program
{
    static void Main(string[] args)
    {
       Ejercicio1();
       Ejercicio2();
       Ejercicio3();
       Ejercicio4();
       Ejercicio5();
    }
    static void Ejercicio1()
    {
        
    
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; 
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
     static void Ejercicio2()
    {
        
    
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; 
        const bool MODO_PRUEBA = false; 
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
     static void Ejercicio3()
    {
        
    
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false; 
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
     static void Ejercicio4()
    {
        
    
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
     static void Ejercicio5()
    {
        
    
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; 
        const bool MODO_PRUEBA = false; 
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
}
