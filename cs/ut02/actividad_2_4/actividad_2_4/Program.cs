namespace actividad_2_4;

class Program
{
    static void Main(string[] args)
    {
        
        Equipo equipo = new Equipo();
        equipo.nombre = "Real Murcia";
        equipo.jugadores = 0;

        Jugador jugador1 = new Jugador();
        jugador1.nombre = "Carlos Martínez";
        jugador1.apodo = "Charly";
        jugador1.dorsal = 9;

        Jugador jugador2 = new Jugador();
        jugador2.nombre = "Luis Gómez";
        jugador2.apodo = "";
        jugador2.dorsal = 4;

        Console.WriteLine("--- GetNombreCorto() ---");
        Console.WriteLine("Jugador 1: " + jugador1.GetNombreCorto());
        Console.WriteLine("Jugador 2: " + jugador2.GetNombreCorto());

        Console.WriteLine();
        Console.WriteLine("--- GetNombreEquipo() antes de fichar ---");
        Console.WriteLine("Jugador 1: " + jugador1.GetNombreEquipo());
        Console.WriteLine("Jugador 2: " + jugador2.GetNombreEquipo());

        equipo.fichar(jugador1);
        equipo.fichar(jugador2);

        Console.WriteLine();
        Console.WriteLine("--- GetNombreEquipo() después de fichar ---");
        Console.WriteLine("Jugador 1: " + jugador1.GetNombreEquipo());
        Console.WriteLine("Jugador 2: " + jugador2.GetNombreEquipo());
    }
}
