void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione enter para continuar");
    Console.ReadLine();
}
Dictionary<int, string> estudiantes = new Dictionary<int, string>();

for(int i=0;  i<5; i++)
{
    Console.Write($"ingrese Nombre del estudiante {i+1}: ");
    estudiantes.Add(i,Console.ReadLine());
    Console.WriteLine();
}
Console.WriteLine("estudiantes ingresados con exito");
Presionar();
Console.Clear();
Console.WriteLine("ID         Nombre estudiante");
foreach(var e in estudiantes)
{
    Console.WriteLine($"{e.Key}         {e.Value}");
}