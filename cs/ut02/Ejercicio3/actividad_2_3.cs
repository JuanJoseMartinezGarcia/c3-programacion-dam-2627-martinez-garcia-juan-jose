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

    // Devuelve los dos apellidos y el nombre.
    // Ejemplo: "García López, Juan"
    public string ObtenerApellidosYNombre()
    {
        return primerApellido + " " + segundoApellido + ", " + nombre;
    }

    // Devuelve el tratamiento, el nombre y el primer apellido separados por espacios.
    // Ejemplo: "Sr. Juan García"
    public string ObtenerTratamientoNombreApellido()
    {
        return tratamiento + " " + nombre + " " + primerApellido;
    }
}