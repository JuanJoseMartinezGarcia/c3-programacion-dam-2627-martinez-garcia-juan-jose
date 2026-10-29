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
            Console.WriteLine("Su valor en positivo es: " + (-num1));
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
            if (num1 % 10 == 0)
            {
                Console.WriteLine("El número es múltiplo de diez");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de diez");
            }
        }
        else
        {
            Console.WriteLine("El número es impar");
        }  
    
    }
}
