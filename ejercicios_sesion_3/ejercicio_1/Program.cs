

var pablo = new Cliente("Pablo","+54 123456789","calle falsa 123","pablo@demo.com",false);

Console.WriteLine(pablo);



public struct Cliente
{
    public Cliente(string nombre, string telefono, string direccion, string email, bool es_nuevo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        Es_nuevo_cliente = es_nuevo;
    }

    public string Nombre { get; }
    public string Telefono { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool Es_nuevo_cliente { get; }


    public override string ToString() => $"Cliente:\n\t Nombre: {Nombre} \n\t Telefono: {Telefono} \n\t Direccion: {Direccion} \n\t Email: {Email} \n\t Es cliente nuevo : {Es_nuevo_cliente}";
}


