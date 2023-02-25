// Ejercicio 1
string? nombre;
string? apellido;
int edad;
string? sabe_programar;
//Ingreso de las variables
Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();

Console.Write("Ingrese su apellido: ");
apellido = Console.ReadLine();

Console.Write("Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese si sabe programar[si/no]: ");
sabe_programar = Console.ReadLine();

string mensaje = $"> {nombre} {apellido}, tienes {edad} años y {(sabe_programar=="si" ? "sabes programar" :"no sabes programar")}";
Console.WriteLine(mensaje);