void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter para continuar");
    Console.ReadLine();
}
Dictionary<string, int> notas = new Dictionary<string, int>();
string opcion;

do
{
    Console.WriteLine("1. ingresar una nota");
    Console.WriteLine("2. ver notas");
    Console.WriteLine("3. modificar nota de un alumno");
    Console.WriteLine("4. Salir");
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
            Console.WriteLine("Nombre del estudiante        Nota");
            foreach (var n in notas)
            {
                Console.WriteLine($"{n.Key}                         {n.Value}");
            }
            Presionar();
            break;
        case "3":
            Console.Write("ingrese nombre del estudiante: ");
            string nombreN= Console.ReadLine();

            if (notas.ContainsKey(nombreN))
            {
                Console.Write("ingrese la nota nueva: ");
                notas[nombreN] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("la nota a sido modificada correctamente");
            }
            else
            {
                Console.WriteLine("el estudiante no exixte");
            }

            Presionar();
            break;
        case "4":
            Console.WriteLine("saliendo...");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }
    Console.Clear();
} while (opcion != "4");