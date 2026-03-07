void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

Dictionary<string, string> ciudades = new Dictionary<string, string>();
string opcion;
do
{
    Console.WriteLine("1. ingresar ciudad: ");
    Console.WriteLine("2. mostrar codigos y ciudades");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    Console.Write("ingres una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingres Codigo de Ciudad: ");
            string codigo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el nombre de la ciudad: ");
            string nombreC = Console.ReadLine();
            Console.WriteLine();
            ciudades.Add(codigo, nombreC);
            Console.WriteLine("Ciudad ingresada correctamente");
            Presionar();
            break;
        case "2":
            Console.Write("codigos de ciudades: ");
            foreach(var c in ciudades)
            {
                Console.Write($"{c.Key}, ");
            }
            Console.WriteLine();
            Console.Write("nombre de ciudades: ");
            foreach (var n in ciudades)
            {

                Console.Write($"{n.Value}, ");
            }

            Presionar();

            break;
        case "3":
            Console.WriteLine("Saliendo...");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }
    Console.Clear();
} while (opcion != "3");