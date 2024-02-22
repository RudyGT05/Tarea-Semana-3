int opcion;
try
{
    Console.WriteLine("Escribe un numero del 1 al 7, para ver a que dia de la semana corresponde");
    
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miercoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6: 
            Console.WriteLine("Sabado");
            break;
        case 7:
            Console.WriteLine("Domingo");
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

