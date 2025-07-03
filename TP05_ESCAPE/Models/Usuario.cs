public class Usuario
{
    public string Nombre { get; set; }
    public string Contraseña { get; set; }
    private string Dni { get; set; }

    public Usuario(string nombre, string contraseña, string dni)
    {
        Nombre = nombre;
        Contraseña = contraseña;
        Dni = dni;
    }

    public string ObtenerDni()
    {
        return Dni;
    }
}
