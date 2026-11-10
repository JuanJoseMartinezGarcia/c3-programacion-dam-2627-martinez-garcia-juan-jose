namespace actividad_3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a calcular! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        long sumatorio=0;
        long factorial=1;

        for (int i = 1; i <= limite_maximo; i++)
        {
            sumatorio += i;
            factorial *= i;
        }

        Console.WriteLine("Sumatorio: " + sumatorio);
        Console.WriteLine("Factorial: " + factorial);
    }
}