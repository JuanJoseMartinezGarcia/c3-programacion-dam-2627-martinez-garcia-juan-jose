namespace actividad_3_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce números positivos. Para terminar, introduce el cero o un número negativo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int sumatorio = 0;
        int contador = 0;

        while (numero > 0)
        {
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Sumatorio: " + sumatorio);
    }
}