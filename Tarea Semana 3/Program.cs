int num, edad;

try
{
    Console.WriteLine("Ingrese su edad: ");
    edad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el monto deseado: ");
    num = int.Parse(Console.ReadLine());


    if (edad >= 60 || num <= 5000) { 

    Console.WriteLine("Su prestamo ha sido aprobado");
}
    else {Console.WriteLine("Lamentablemente su prestamo ha sido rechazado");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Solo se pueden escribir numeros "+ ex.Message);
}

