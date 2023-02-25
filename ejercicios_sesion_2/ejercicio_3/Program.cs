//Operadores
int numero = 35;
bool mayor = numero >= 18;
Console.WriteLine($"{numero} es mayor que 18: {mayor}");

char caracter = 't';
bool igual = caracter == 'a';
Console.WriteLine($"{caracter} es igual al char 'a': {igual}");

bool and = mayor && igual;
Console.WriteLine($"Condicion: {mayor} && {igual}: {and}");

bool or = mayor || igual;
Console.WriteLine($"Condicion: {mayor} || {igual}: {or}");