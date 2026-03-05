Dictionary<int , string> estrudiante = new Dictionary<int , string>();
int contE=0;
string opcion;

do
{
    Console.WriteLine("1. ingresar estudiante");
    Console.WriteLine("2. mostrar todos lo estudiantes");
    Console.WriteLine("3. buscar estudiante");
    Console.WriteLine("4. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");

    opcion=Console.ReadLine();
    Console.Clear();
    switch (opcion)
    {
        case "1":
            if (contE >=0 && contE<3)
            {
                Console.Write("ingrese nombre del estudiante: ");
                estrudiante.Add(contE, Console.ReadLine());
                contE++;

                Console.WriteLine("estudiante resgistrado con exito");
            }
            else if (contE >=2)
            {
                Console.WriteLine("solo puede ingresar 3 estudiantes");
            }

            Console.WriteLine();
            Console.WriteLine("Presione enter para finalizar");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("ID        estudiante");
            Console.WriteLine();
            foreach(var n in estrudiante)
            {
                Console.WriteLine($"{n.Key}         {n.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Presione enter para finalizar");
            Console.ReadLine();
            break;
        case "3":
            Console.Write("ingrese ID del estudiante: ");
            int ID=int.Parse(Console.ReadLine());

            if (estrudiante.ContainsKey(ID))
            {
                Console.WriteLine($"estudiante encontrado: {estrudiante[ID]}");
            }
            else
            {
                Console.WriteLine("numero de ID no existente");
            }

            Console.WriteLine();
            Console.WriteLine("Presione enter para finalizar");
            Console.ReadLine();
            break;
        case "4":
            Console.Write("saliendo");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            break;
        default:
            Console.WriteLine("opcion no valida");
            Console.WriteLine();
            Console.WriteLine("Presione enter para finalizar");
            Console.ReadLine();
            break;
    }
    Console.Clear();
} while (opcion!="4");