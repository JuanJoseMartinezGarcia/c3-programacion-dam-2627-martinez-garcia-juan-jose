class Persona
{
    string tratamiento;
    string nombre;
    string primerApellido;
    string segundoApellido;

    // Devuelve el nombre y los dos apellidos separados por espacios.
    // Ejemplo: "Juan García López"
    public string ObtenerNombreCompleto()
    {
        return nombre + " " + primerApellido + " " + segundoApellido;
    }
}