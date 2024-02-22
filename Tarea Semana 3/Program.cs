string usu, contra;
try
{
    Console.WriteLine("Ingrese el usuario: ");
    usu = (Console.ReadLine());
    Console.WriteLine("Ingrese la contraseña: ");
    contra = (Console.ReadLine());



    if (usu == "Rudy" && contra == "1234") { 

    Console.WriteLine("Bienvenido, Rudy ");
}
    else {
        Console.WriteLine("Contraseña incorrecta, vuelva a intentarlo");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

