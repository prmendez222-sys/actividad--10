Dictionary<int , string> estrudiante = new Dictionary<int , string>();
int contE=0;
string opcion;

do
{
    Console.WriteLine("1. ingresar estudiante");
    Console.WriteLine("2. buscar estudiante");
    Console.WriteLine("3.salir");
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
    }
    Console.Clear();
} while (opcion!="3");