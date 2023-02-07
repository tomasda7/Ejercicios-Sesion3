//Crea una estructura de datos para un cliente con estos campos:
//Nombre completo
//Teléfono
//Dirección
//Email
//Si es nuevo cliente
//Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)

Cliente cliente = new Cliente();

Cliente newCliente = cliente with { 
    nombre = "Julian Alvarez", 
    telefono = 3888987654, 
    direccion = "CalleFalsa 223", 
    email = "araña@email.com",
    esNuevo = true
} ;

Console.WriteLine(newCliente);

public struct Cliente
{
    public Cliente(string nombre, long telefono, string direccion, string email, bool esNuevo) {

        this.nombre = nombre;

        this.telefono = telefono;

        this.direccion = direccion;

        this.email = email;

        this.esNuevo = esNuevo;
    }

    public string nombre { get; set; }
    public long telefono { get; set; }
    public string direccion { get; set; }
    public string email { get; set; }
    public bool esNuevo { get; set; }

    public override string ToString() => 
        $"(Nombre: {nombre}, Telefono: {telefono}, Direccion: {direccion}, Email: {email}, Es nuevo: {esNuevo})";

}