int prim, segun, tern;
try
{
    Console.WriteLine("Ingrese el primer numero: ");
    prim = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    segun = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tercer numero: ");
    tern = int.Parse(Console.ReadLine());
    if (prim > segun && prim > tern)
        Console.WriteLine("El mayor es: " + prim);
    else if (segun > prim && segun > tern)
        Console.WriteLine("El mayor es: " + segun);
    else if (tern > segun && tern > prim)
        Console.WriteLine("El mayor es: " + tern);
}
catch (Exception ex)
{
    Console.WriteLine("Solo se permiten numeros " + ex.Message);
}

