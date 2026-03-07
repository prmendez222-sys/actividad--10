void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

Dictionary<int,string> estudiantes = new Dictionary<int,string>();
string opcion;

for (int i = 0; i < 3; i++)
{
    Console.Write($"ingrese nombre del estudiante {i+1}: ");
    estudiantes.Add(i, Console.ReadLine());
    Console.WriteLine();
}

Console.WriteLine("estudiantes registrados correctamente");
Presionar();
Console.Clear();

do
{
    Console.WriteLine("1. ver estudiantes");
    Console.WriteLine("2. eliminar estudiantes por ID");
    Console.WriteLine("3. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion= Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.WriteLine("ID          Nombre estudiante");
            Console.WriteLine();
            foreach(var e in estudiantes)
            {
                Console.WriteLine($"{e.Key}          {e.Value}");
            }
            Presionar();
            break;
        case "2":
            Console.Write("ingrese ID del estudiante: ");
            int id=int.Parse(Console.ReadLine());

            if (estudiantes.ContainsKey(id))
            {
                estudiantes.Remove(id);
                Console.WriteLine("estudiante eliminado con exito");
            }
            else
            {
                Console.WriteLine("estudiante no existente");
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
} while (opcion!="3");