namespace actividad_2_1;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Stopwatch es una clase, cronometro es la variable objeto.
        // Se declara la variable y se instancia el objeto con new.
        Stopwatch cronometro = new Stopwatch();

        cronometro.Start();

        Console.WriteLine("Pulsa INTRO lo más rápido posible...");
        Console.ReadLine();

        cronometro.Stop();

        Console.WriteLine($"Has tardado {cronometro.ElapsedMilliseconds} ms");
    }
}