double precio, totalf, des;
try
{
    Console.WriteLine("Ingrese el precio del producto: ");
    precio = double.Parse(Console.ReadLine());


    if (precio >= 100) { 
        des = precio * 0.10;
    totalf = precio - des;
    Console.WriteLine("Con el descuento aplicado su total es de: " + totalf);
}
    else {
        Console.WriteLine("Su precio final es: " + precio);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Solo puedes ingresar números "+ex.Message);
}

