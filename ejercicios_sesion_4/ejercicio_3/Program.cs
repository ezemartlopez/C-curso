Console.Write("Ingrese el ancho del rectangulo: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el alto del rectangulo: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese [si/no] quiere rellenar el rectangulo: ");
bool relleno = Console.ReadLine() == "si";

for (int i = 1; i <= alto; i++)
{
    for (int j = 1; j <= ancho; j++)
    {   
        //si no pide relleno y los cuadros coinciden con una posicion interna del rectangulo
        if(!relleno && (i > 1 && i < alto) && (j > 1 && j < ancho)){
            Console.Write("   ");
        }
        //si no estamos hablando de los margenes del rectangulo, tambien abarca el caso tener relleno
        else
        {
            Console.Write("|_|");
        }
        
    }
    Console.Write("\n");
}