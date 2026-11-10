namespace actividad_3_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecciona un número positivo (no mayor de 10000) y yo te diré sus divisores:");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 2 && numero <= 10000)
        {
            Console.WriteLine($"Los divisores de {numero} son:");
            int test_divisor = numero;
            /* PROFESOR::usando un bucle while, completa el programa para que en cada paso reste 1 a test_divisor
               y compruebe si test_divisor es divisor del número introducido. Si lo es, muéstralo por pantalla.
               El bucle debe terminar cuando test_divisor sea igual a 2, ya que el 1 divide a cualquiera y no se considera un divisor propio.
            */
        }
        else
        {
            Console.WriteLine("El número debe estar entre 2 y 10000 (ambos incluidos)");
        }
    }
}