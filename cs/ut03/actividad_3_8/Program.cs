namespace actividad_3_8;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_MIN = 2;
        const int NUMERO_MAX = 10000;

        Console.WriteLine("Selecciona un número positivo (no mayor de 10000) y yo te diré sus divisores:");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= NUMERO_MIN && numero <= NUMERO_MAX)
        {
            Console.WriteLine($"Los divisores de {numero} son:");
            int test_divisor = numero;

            while (test_divisor >= 2)
            {
                if (numero % test_divisor == 0)
                {
                    Console.WriteLine($"El número {test_divisor} es divisor de {numero}");
                }
                test_divisor--;
            }
        }
        else
        {
            Console.WriteLine("El número debe estar entre 2 y 10000 (ambos incluidos)");
        }
    }
}