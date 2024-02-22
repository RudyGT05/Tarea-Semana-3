int opcion;
try
{
    Console.WriteLine("Escribe un numero del 1 al 5");
    
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Uno");
            break;
        case 2:
            Console.WriteLine("Dos");
            break;
        case 3:
            Console.WriteLine("Tres");
            break;
        case 4:
            Console.WriteLine("Cuatro");
            break;
        case 5:
            Console.WriteLine("Cinco");
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

