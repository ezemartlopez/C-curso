Console.Write("Ingrese su nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Ingrese su email: ");
string? email = Console.ReadLine();

Console.Write("Tiene cupon [si/no]: ");
bool tiene_cupon = Console.ReadLine() == "si" ;

double precio_producto = 15000d;
double descuento = 10d;

if(tiene_cupon){
    Console.WriteLine($"Tiene un cupon de descuento del {descuento}%.");
    Console.WriteLine($"Precio del producto: {precio_producto}");
    double total = precio_producto - precio_producto * (descuento / 100);
    Console.WriteLine($"precio total con descuento: {total}");
}
else
{
    Console.WriteLine($"No tiene un cupon de descuento.");
    Console.WriteLine($"Precio del producto: {precio_producto}");    
}