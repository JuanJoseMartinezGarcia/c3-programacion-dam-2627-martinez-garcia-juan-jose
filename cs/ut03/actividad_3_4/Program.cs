namespace actividad_3_4;

class Program
{
    static void Main(string[] args)
    {
        const string RATING_TEXT = "El curso te parece ";
        const string RATING_1 = "horroroso";
        const string RATING_2 = "malo";
        const string RATING_3 = "regulero";
        const string RATING_4 = "interesante";
        const string RATING_5 = "maravilloso";
        const string RATING_ERROR = "Debes indicar un valor entre 1 y 5 (incluidos)";

        Console.WriteLine("Califica tu experiencia con el curso (1-5):");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        string valoracion = "";

        switch (calificacion)
        {
            case 1:
                valoracion = RATING_1;
                break;
            case 2:
                valoracion = RATING_2;
                break;
            case 3:
                valoracion = RATING_3;
                break;
            case 4:
                valoracion = RATING_4;
                break;
            case 5:
                valoracion = RATING_5;
                break;
            default:
                Console.WriteLine(RATING_ERROR);
                return;
        }

        Console.WriteLine(RATING_TEXT + valoracion);
    }
}