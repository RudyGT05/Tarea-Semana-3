int edad;
try
{
    Console.WriteLine("Ingrese su edad: ");
    edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
        Console.WriteLine("Bienvenido");
    else 
        Console.WriteLine("No puedes ingresar");
    
}
catch (Exception ex)
{
    Console.WriteLine("Solo puedes ingresar números "+ex.Message);
}

