void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

Dictionary<int, string> empleados = new Dictionary<int, string>();
string opcion;
int contE = 0;
do
{
    Console.WriteLine("1. ingrese un nuevo Empleado: ");
    Console.WriteLine("2. ver empleados");
    Console.WriteLine("3. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("ingrese nombre del empleado: ");
            empleados.Add(contE, Console.ReadLine());
            contE++;
            Console.WriteLine("empleado registrado con exito");
            Presionar();
            break;
        case "2":
            Console.WriteLine("ID          Nombre de Empleado");
            foreach (var e in empleados)
            {
                Console.WriteLine($"{e.Key}          {e.Value}");
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
    Console.Clear();
} while (opcion != "3");