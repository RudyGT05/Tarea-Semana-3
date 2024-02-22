int opcion;
try
{
    Console.WriteLine("Ingresa tu nota para evaluar tu desempeño");
 

    
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case >=60 and <=69:
            Console.WriteLine("No aprobatoria");
            break;
        case >=70 and <=79:
            Console.WriteLine("Aprobatoria");
            break;
        case >=80 and <=89:
            Console.WriteLine("Notable");
            break;
        case >= 90 and <= 100:
            Console.WriteLine("Sobresaliente");
            break;
       
        default:
            Console.WriteLine("La nota no puede ser evaludad");
            break;
    }



   
}
catch (Exception ex)
{
    Console.WriteLine("Solo se pueden escribir numeros "+ ex.Message);
}

