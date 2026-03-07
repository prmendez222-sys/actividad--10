void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para finalizar");
    Console.ReadLine();
}

Dictionary<string,(string nombre,string edad,string carrera)> estudiante = new Dictionary<string, (string, string, string)>();
string opcion;
int contE = 0;

do
{
    Console.WriteLine("1. agregar estudiante");
    Console.WriteLine("2. ver estudiantes");
    Console.WriteLine("3.salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion= Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            if(contE>=0 && contE < 3)
            {
                Console.Write("ingrese Carnet del estudiante: ");
                string carnet = Console.ReadLine();
                Console.WriteLine();
                if (estudiante.ContainsKey(carnet))
                {
                    Console.WriteLine("el numero de cartet ya existe");
                }
                else
                {
                    Console.Write("ingrese Nombre del estudiante: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Ingrese la edad: ");
                    string edad = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("ingrese la carrera: ");
                    string carrera = Console.ReadLine();
                    Console.WriteLine();

                    estudiante.Add(carnet, (nombre, edad, carrera));
                    contE++;
                    Console.WriteLine("estudiante registrado con exito");
                }
            }
            else
            {
                Console.WriteLine("solo puede ingresar 3 estudiantes");
            }
            Presionar();
            break;
        case "2":
            Console.WriteLine("carnet                  nombre estudiante          edad     carrera");
            foreach(var e in estudiante)
            {
                Console.WriteLine($"{e.Key}              {e.Value.nombre}               {e.Value.edad}       {e.Value.carrera}");
            }
            Presionar();
            break;
        case "3":
            Console.WriteLine("saliendo....");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }
    Console.Clear();
} while (opcion != "3");