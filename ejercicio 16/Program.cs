void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

Dictionary<int, string> estudiantes = new Dictionary<int, string>();
string opcion;
int contE = 0;
do
{
    Console.WriteLine("1. ingrese un nuevo estudiante: ");
    Console.WriteLine("2. ver estudiantes");
    Console.WriteLine("3. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("ingrese nombre del empleado: ");
            estudiantes.Add(contE, Console.ReadLine());
            contE++;
            Console.WriteLine("estudiante registrado con exito");
            Presionar();
            break;
        case "2":
            Console.WriteLine("ID          Nombre del Estudiante");
            foreach (var e in estudiantes)
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