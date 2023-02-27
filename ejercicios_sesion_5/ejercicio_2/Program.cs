var lenguajes = new List<string> {"C#","Java","C++"};
int i = 1;
Console.WriteLine("Elija una opcion: ");
foreach (var lenguaje in lenguajes)
{
    Console.WriteLine($"{i}) {lenguaje}");
    i++;
}
Console.Write("\n opcion: ");
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Hola, Mundo con C#!!");
        break;
    case 2:
        Console.WriteLine("Hola, Mundo con Java!!");
        break;
    case 3:
        Console.WriteLine("Hola, Mundo con C++ !!");
        break;
    default:
        Console.WriteLine("Esta opcion no existe");
        break;
}