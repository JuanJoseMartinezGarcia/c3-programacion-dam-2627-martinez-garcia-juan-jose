namespace actividad_3_11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Voy a mostrarte la tabla de multiplicar del número que me digas!");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("El número indicado debe estar entre 1 y 10");
        }
    }
}