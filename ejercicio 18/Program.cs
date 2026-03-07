Dictionary<string,string> usuario = new Dictionary<string,string>();
int ContU=0;
string opcion;

do
{
    Console.WriteLine("1. ingrese usuario");
    Console.WriteLine("2. salir");
    Console.WriteLine();
    Console.Write("Ingrese una opcion: ");
    opcion= Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("ingrese nombre de usuario: ");
            string nombreU=Console.ReadLine();

            if (usuario.ContainsKey(nombreU))
            {
                Console.WriteLine("el usuario ya existe");
            }
            else
            {
                Console.Write("ingrese una contraseña: ");
                usuario.Add(nombreU, Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("usuario ingresado correctamente");
            }
            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("saliendo...");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
    }
    Console.Clear();
} while (opcion != "2");