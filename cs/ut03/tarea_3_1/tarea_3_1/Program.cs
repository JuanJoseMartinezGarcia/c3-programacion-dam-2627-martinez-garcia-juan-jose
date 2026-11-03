namespace tarea_3_1;

class Program
{
    static void Main(string[] args)
    {
        //apartado b - usando condicionales, desarrolla aquí el código que pide el enunciado:
        Console.WriteLine("Indica una letra:");
        string letra = Console.ReadLine();

        if (letra.Length>1)
        {
            Console.WriteLine($"No puedes indicar un texto con más de una letra");
        }
        else if (letra.Length=0)
        {
            Console.WriteLine($"No puedes dejar el texto en blanco");
        }
        else
        {
            Console.WriteLine($"Tu letra en mayúscula es {letra.ToUpper()}");
        }

        //apartado c - usando un bucle for, desarrolla aquí el código que pide el enunciado:
        Console.WriteLine("Indica un valor de porventaje para contar hacia atrás desde 100 hasta 0:");
        int resta = Convert.ToInt32(Console.ReadLine());

        for (int porcentaje=100; porcentaje<=resta; porcentaje--)
        {
            porcentaje = porcentaje - resta;

        }
                Console.WriteLine($"Finalizado)");
            


        //apartado d - usando un bucle while, desarrolla aquí el código que pide el enunciado:

        //apartado e - usando un bucle do-while, desarrolla aquí el código que pide el enunciado:

        //apartado f - usando diferentes condicionales y bucles, con posible anidación, desarrolla aquí el código que pide el enunciado:

        //apartado g - usando capturas con try-catch-finally, completa aquí el código que pide el enunciado:
        int litros = 0, dias = 0, personas = 0;
        Console.WriteLine("Indique el número de litros, de días y de personas:");
        litros = int.Parse(Console.ReadLine());
        dias = int.Parse(Console.ReadLine());
        personas = int.Parse(Console.ReadLine());
        int racion = litros / (dias * personas);
        Console.WriteLine($"La ración de litros por persona y día es: {racion}");
        Console.WriteLine("El procedimiento de reparto ha finalizado, compruebe si hay errores.");
    }
}
