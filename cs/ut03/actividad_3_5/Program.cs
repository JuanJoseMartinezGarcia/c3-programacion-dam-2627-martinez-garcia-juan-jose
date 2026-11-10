namespace actividad_3_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a contar! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= limite_maximo; i++)
        {
            Console.WriteLine(i);
        }
    }
}