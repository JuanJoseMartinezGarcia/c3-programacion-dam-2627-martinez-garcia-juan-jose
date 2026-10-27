namespace actividad_2_4;

class Jugador
{
    public string nombre;
    public string apodo;
    public Equipo equipo; // referencia al objeto "Equipo" en el que juega
    public int dorsal; //número de dorsal en el equipo
    
    public string GetNombreCorto()
    {
        if (apodo == "")
        {
            return nombre;
        }
        return apodo;
    }

    public string GetNombreEquipo()
    {
        return equipo.nombre;
    }
}