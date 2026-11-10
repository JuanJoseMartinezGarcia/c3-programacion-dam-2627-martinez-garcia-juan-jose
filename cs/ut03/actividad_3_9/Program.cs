namespace actividad_3_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce una palabra");
        string palabra = Console.ReadLine();
        Console.WriteLine("Introduce un número de repeticiones:");
        int repeticiones = int.Parse(Console.ReadLine());

        for (int i = 0; i < repeticiones; i++)
        {
            Console.WriteLine(palabra);
        }
    }
}