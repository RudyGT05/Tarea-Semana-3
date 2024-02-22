int num;
try
{
    Console.WriteLine("Ingrese el numero a examinar: ");
    num = int.Parse(Console.ReadLine());


    if (num % 2 == 0) { 

    Console.WriteLine("El numero es par");
}
    else {Console.WriteLine("El numero es impar");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Solo Se pueden ingresar números "+ex.Message);
}

