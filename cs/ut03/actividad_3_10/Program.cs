namespace actividad_3_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra y yo me encargaré de acortarla hasta que quede en nada:");
        string palabra = Console.ReadLine();

        do
        {
            palabra = palabra.Substring(1, palabra.Length - 2);
            Console.WriteLine(palabra);
        } while (palabra.Length >= 2);
    }
}