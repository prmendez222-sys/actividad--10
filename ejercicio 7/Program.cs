void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}
Dictionary<string, string> prodructos = new Dictionary<string, string>();
string opcion;

do
{
    Console.WriteLine("1. ingresar Producto");
    Console.WriteLine("2. ver lista de productos");
    Console.WriteLine("3. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("ingrese ID del Producto: ");
            string idP= Console.ReadLine();
            Console.WriteLine();

            if (prodructos.ContainsKey(idP))
            {
                Console.WriteLine("el ID ya existe");
            }
            else
            {
                Console.Write("ingrese nombre del Producto: ");
                string nombreP = Console.ReadLine();
                Console.WriteLine();
                prodructos.Add(idP, nombreP);
                Console.WriteLine("Producto ingresado con exito");
            }
            Presionar();

            break;
        case "2":
            if (prodructos.Count == 0)
            {
                Console.WriteLine("no hay productos ingresados");
            }
            else
            {
                Console.WriteLine("ID         nombre del Producto");
                foreach (var p in prodructos)
                {
                    Console.WriteLine($"{p.Key}          {p.Value}");
                }
            }
            Presionar();
            break;
        case "3":
            Console.WriteLine("saliendo...");
            Thread.Sleep(2000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }

    Console.Clear();

} while (opcion != "3");