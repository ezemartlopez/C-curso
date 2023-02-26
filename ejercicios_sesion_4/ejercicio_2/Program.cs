
int positivos = 0;
int negativos = 0;
int numero;
do
{
    Console.Write("Ingrese un numero entero [(ctrl + c) para salir]: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero >= 0){
        positivos++;
        Console.WriteLine("Es un numero positivo");
    }
    else
    {
        negativos++;
        Console.WriteLine("Es un numero negativo");
    }
    Console.WriteLine($"Total de positivos: {positivos} \nTotal de negativos: {negativos}");
} while (true);

