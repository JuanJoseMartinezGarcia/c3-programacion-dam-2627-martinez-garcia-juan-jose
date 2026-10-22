namespace actividad_2_1;

/*
 * using permite utilizar los tipos definidos en un espacio de nombres
 * sin tener que escribir su nombre completo.
 * System.Diagnostics contiene la clase Stopwatch, que permite medir
 * el tiempo transcurrido durante la ejecución del programa.
 */
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Stopwatch es una clase, cronometro es la variable objeto.
        // Se declara la variable y se instancia el objeto con new.
        Stopwatch cronometro = new Stopwatch();

        cronometro.Start(); //método Start

        Console.WriteLine("Pulsa INTRO lo más rápido posible...");
        Console.ReadLine();

        cronometro.Stop(); //método Stop

        // Elapsed es una propiedad que devuelve un objeto TimeSpan.
        TimeSpan ts = cronometro.Elapsed;

        Console.WriteLine($"Has tardado {ts.Seconds} segundos y {ts.Milliseconds} milisegundos");
    }
}