using System.Timers;

void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}
Dictionary<int, string> prodructos = new Dictionary<int, string>();
string opcion;
int contP = 0;
do
{
    Console.WriteLine("1. ingresar Producto");
    Console.WriteLine("2. ver lista de productos");
    Console.WriteLine("3. eliminar Producto");
    Console.WriteLine("4. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("ingrese nombre del Producto: ");
            prodructos.Add(contP, Console.ReadLine());
            contP++;
            Console.WriteLine();
            Console.WriteLine("Producto ingresado con exito");
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