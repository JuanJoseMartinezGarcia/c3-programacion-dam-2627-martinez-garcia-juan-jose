namespace actividad_3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a calcular! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        long sumatorio=0;
        long factorial=1;

        Console.WriteLine($"Introduce el entero base para el cálculo, entre 1 y {limite_maximo}");
        int entero_base = Convert.ToInt32(Console.ReadLine());

        for (int i = entero_base; i <= limite_maximo; i++)
        {
            sumatorio += i;
            factorial *= i;
        }

        Console.WriteLine("Sumatorio: " + sumatorio);
        Console.WriteLine("Factorial: " + factorial);
    }
}