namespace actividad_3_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Califica tu experiencia con el curso (1-5):");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        switch (calificacion)
        {
            case 1:
                Console.WriteLine("El curso te parece horroroso");
                break;
            case 2:
                Console.WriteLine("El curso te parece malo");
                break;
            case 3:
                Console.WriteLine("El curso te parece regulero");
                break;
            case 4:
                Console.WriteLine("El curso te parece interesante");
                break;
            case 5:
                Console.WriteLine("El curso te parece maravilloso");
                break;
        }
    }
}