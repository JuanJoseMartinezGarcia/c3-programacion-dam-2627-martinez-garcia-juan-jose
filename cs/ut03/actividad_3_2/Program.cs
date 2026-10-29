namespace actividad_3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indica un número entero y yo intentaré decirte algo sobre él:");        
        int num1 = Convert.ToInt32(Console.ReadLine());
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
    
        if (num1 < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else if (num1 == 0)
        {
            Console.WriteLine("El número es cero");
        }
        else
        {
            Console.WriteLine("El número es positivo");
        }

        if (num1 % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }   
    
    }
}
