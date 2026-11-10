namespace actividad_3_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra y yo me encargaré de acortarla hasta que quede en nada:");
        string palabra = Console.ReadLine();

        do
        {
            palabra = palabra.Substring(0, palabra.Length - 1);
            Console.WriteLine(palabra);
        } while (palabra.Length > 0);
    }
}