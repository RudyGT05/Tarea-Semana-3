int opcion, baset, alturat, areat, ladocua, areacua, radiocir;
double areacir;

try
{
    Console.WriteLine("Bienvenido, elija la opcion deseada");
    Console.WriteLine("1. Circulo");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Triangulo");
    opcion = int.Parse(Console.ReadLine());



    if (opcion == 1)
    {

        Console.WriteLine("Ingrese el radio del circulo");
        radiocir = int.Parse(Console.ReadLine());
        areacir = (radiocir * radiocir) +3.1416;
        Console.WriteLine("El Area del circulo es de: " + areacir);

    }
    else if (opcion == 2)
    {
        Console.WriteLine("Ingrese el largo del cuadrado");
        ladocua = int.Parse(Console.ReadLine());
        areacua = ladocua * ladocua;
        Console.WriteLine("El Area del cuadrado es de: " + areacua);    

    }
    else if (opcion == 3)
    {
        Console.WriteLine("Ingrese la base del triangulo");
        baset = int.Parse (Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triangulo");
        alturat = int.Parse (Console.ReadLine());
        areat = (baset * alturat) / 2;
        Console.WriteLine("El area del triangulo es: " + areat);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Solo se pueden escribir numeros "+ ex.Message);
}

