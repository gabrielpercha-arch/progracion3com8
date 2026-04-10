class Programm
{
    static void Main(string[] args)
    {
    
       Ejercicio01();
       Ejercicio02();
       Ejercicio03();
       Ejercicio04();
       Ejercicio05();
    
    }
 //Definicion del primer ejercicio como metodo
    static void  Ejercicio01()
    {
         // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad
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
//Definicion del segundo ejercicio como metodo
    static void  Ejercicio02()
    {
    
         // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad
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
    //Definicion del tercer ejercicio como metodo
    static void  Ejercicio03()
    {
        
        // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad
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
    //Definicion del cuarto ejercicio como metodo
    static void  Ejercicio04()
    {
         // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad
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
    //Definicion del quinto ejercicio como metodo
    static void  Ejercicio05()
    {
         // --- CONSTANTES DE CALCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad
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

