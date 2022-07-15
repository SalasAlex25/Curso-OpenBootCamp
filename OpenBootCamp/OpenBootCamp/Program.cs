Persona oPersona = new Persona("Alex Salas", "Calle falsa", 153169247, "alex@hotmail.com", false);
Console.WriteLine(oPersona.ToString());
public class Persona 
{
    string nombreCompleto;
    string direccion;
    int telefono;
    string email;
    bool esNuevo;

    public Persona()
    {
        nombreCompleto = "";
        direccion = "";
        telefono = 0;
        email = "";
        esNuevo = false;
    }
    
    public Persona(string nombreCompleto, string direccion, int telefono, string email, bool esNuevo)
    {
        this.nombreCompleto = nombreCompleto;
        this.direccion = direccion;
        this.telefono = telefono;
        this.email = email;
        this.esNuevo = esNuevo;
    }
    public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
    public string Direccion { get { return direccion; } set { direccion = value; } }
    public int Telefono { get { return telefono; } set { telefono = value; } }
    string Email { get { return email; } set { email = value; } }
    bool Esnuevo { get { return esNuevo; } set { esNuevo = value; } }
    
    override
    public string ToString()
    {
        string aux="NO";
        if (esNuevo)
        {
            aux = "SI";
        }
        return "Nombre Completo: " + nombreCompleto + " Direccion: " + direccion + " Telefono: " + telefono + " Email: " + email + " Es nuevo: " + aux;
    }

}