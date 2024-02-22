int opcion;
try
{
    Console.WriteLine("Elije el idioma que deseas");
    Console.WriteLine("1. Español");
    Console.WriteLine("2. Inglés");
    Console.WriteLine("3. Francés");

    
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Bienvenido Que la pases bien");
            break;
        case 2:
            Console.WriteLine("Welcome, have fun");
            break;
        case 3:
            Console.WriteLine("Bienvenue, passez un bon moment");
            break;
       
        default:
            Console.WriteLine("Numero no disponible,numéro non disponible, number not avaliable");
            break;
    }



   
}
catch (Exception ex)
{
    Console.WriteLine("Solo se pueden escribir numeros "+ ex.Message);
}

