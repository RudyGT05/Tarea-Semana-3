int opcion;
try
{
    Console.WriteLine("Elije la opcion que quieres");
    Console.WriteLine("1. Lavado de Auto");
    Console.WriteLine("2. Cambio de Aceite");
    Console.WriteLine("3. Revision Mecanica");

    
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Tienes que pagar Q40");
            break;
        case 2:
            Console.WriteLine("Tienes que pagar Q500");
            break;
        case 3:
            Console.WriteLine("Tienes que Pagar Q200");
            break;
       
        default:
            Console.WriteLine("Numero no disponible");
            break;
    }



   
}
catch (Exception ex)
{
    Console.WriteLine("Solo se pueden escribir numeros "+ ex.Message);
}

