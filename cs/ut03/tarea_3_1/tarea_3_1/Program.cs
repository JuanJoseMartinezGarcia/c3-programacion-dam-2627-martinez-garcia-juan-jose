namespace tarea_3_1;

class Program
{
    static void Main(string[] args)
    {
        //apartado b - usando condicionales, desarrolla aquí el código que pide el enunciado:
        Console.WriteLine("Indica una letra:");
        string letra = Console.ReadLine();

        //apartado c - usando un bucle for, desarrolla aquí el código que pide el enunciado:

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
