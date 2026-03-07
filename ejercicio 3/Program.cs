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
    Console.WriteLine("2. buscar estudiante por nombre");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    Console.Write("ingrese una Opcion: ");
    opcion= Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese nombre del estudiante: ");
            string nombre= Console.ReadLine();
            Console.WriteLine();
            Console.Write("ingrese nota del estudiante: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine();
            notas.Add(nombre, nota);
            Console.WriteLine("nota ingresada correctamente");
            Presionar();
            break;
        case "2":
            Console.WriteLine("ingrese nombre del estudiante");
            string nombreN= Console.ReadLine();
            nombreN = nombreN.ToLower();

            if (notas.ContainsKey(nombreN))
            {
                Console.WriteLine($"la nota de {nombreN} es: {notas[nombreN]}");
            }
            else
            {
                Console.WriteLine("el estudiante no existe");
            }

            Presionar();
            break;
    }
    Console.Clear();
} while (opcion != "3");