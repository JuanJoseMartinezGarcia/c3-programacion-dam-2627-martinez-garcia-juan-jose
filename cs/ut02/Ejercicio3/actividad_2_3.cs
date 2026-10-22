class Persona
{
    public string tratamiento;
    public string nombre;
    public string primerApellido;
    public string segundoApellido;

    // Devuelve el nombre y los dos apellidos.
    // Ejemplo: "Juan Garcia Lopez"
    public string ObtenerNombreCompleto()
    {
        return nombre + " " + primerApellido + " " + segundoApellido;
    }

    // Devuelve los dos apellidos y el nombre.
    // Ejemplo: "Garcia Lopez, Juan"
    public string ObtenerApellidosYNombre()
    {
        return primerApellido + " " + segundoApellido + ", " + nombre;
    }

    // Devuelve el tratamiento, el nombre y el primer apellido.
    // Ejemplo: "Sr. Juan Garcia"
    public string ObtenerTratamientoNombreApellido()
    {
        return tratamiento + " " + nombre + " " + primerApellido;
    }
}

// Creamos el objeto de un hombre
Persona persona1 = new Persona();
persona1.tratamiento = "Sr.";
persona1.nombre = "Juan";
persona1.primerApellido = "Garcia";
persona1.segundoApellido = "Lopez";

// Creamos el objeto de una mujer
Persona persona2 = new Persona();
persona2.tratamiento = "Sra.";
persona2.nombre = "Maria";
persona2.primerApellido = "Perez";
persona2.segundoApellido = "Sanchez";

// Probamos todos los métodos del hombre
Console.WriteLine(persona1.ObtenerNombreCompleto());
Console.WriteLine(persona1.ObtenerApellidosYNombre());
Console.WriteLine(persona1.ObtenerTratamientoNombreApellido());

// Probamos todos los métodos de la mujer
Console.WriteLine(persona2.ObtenerNombreCompleto());
Console.WriteLine(persona2.ObtenerApellidosYNombre());
Console.WriteLine(persona2.ObtenerTratamientoNombreApellido());