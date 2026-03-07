void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.WriteLine();
}
Dictionary<string,string> usuario= new Dictionary<string,string>();
string opcion;
do
{
    Console.WriteLine("1. ingresar Usuario");
    Console.WriteLine("2. ver Contraseña de usuario");
    Console.WriteLine("3. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion= Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese nombre de Usuario: ");
            string nombreU= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese una contraseña: ");
            string ContrasenaU= Console.ReadLine();
            usuario.Add(nombreU, ContrasenaU);
            Console.WriteLine();
            Console.WriteLine("usuario ingresado Correctamente");
            Presionar();
            break;
        case "2":
            Console.Write("ingrese un usuario: ");
            string usuarioN= Console.ReadLine();

            if (usuario.ContainsKey(usuarioN))
            {
                Console.WriteLine($"la contraseña de {usuarioN} es: {usuario[usuarioN]}");
            }
            else
            {
                Console.WriteLine("el usuario no existe");
            }
            Presionar();
            break;
        case "3":
            Console.WriteLine("saliendo...");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }
} while (opcion!="3");