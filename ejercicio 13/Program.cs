void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter para continuar");
    Console.ReadLine();
}
Dictionary<string, double> notas = new Dictionary<string, double>();
string opcion;

do
{
    Console.WriteLine("1. ingresar una nota");
    Console.WriteLine("2. Promedio de notas");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    Console.Write("ingrese una Opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ingrese nota del estudiante: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine();
            notas.Add(nombre, nota);
            Console.WriteLine("nota ingresada correctamente");
            Presionar();
            break;
        case "2":
            double Promedio=0;
            Console.WriteLine("ID        nombre Estudiante");
            foreach(var n in notas)
            {
                Promedio += n.Value;
                Console.WriteLine($"{n.Key}       {n.Value}");
            }
            Console.WriteLine($"Promedio general: {Promedio/notas.Count}");
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