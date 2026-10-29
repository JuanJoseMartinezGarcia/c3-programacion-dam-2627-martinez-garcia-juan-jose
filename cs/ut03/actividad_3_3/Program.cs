namespace actividad_3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nueva contraseña (mínimo 8 caracteres, conteniendo letras mayúsculas y minúsculas):"); 
        string password = Console.ReadLine();
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
       
       if (password.Length < 8)
        {
            Console.WriteLine("Demasiado corta, debe contener al menos 8 caracteres");
        }

        else
        {
            bool tieneMayuscula = false;
            bool tieneMinuscula = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    tieneMayuscula = true;
                }
                if (char.IsLower(c))
                {
                    tieneMinuscula = true;
                }
            }

            if (tieneMayuscula && tieneMinuscula)
            {
                Console.WriteLine("Contraseña válida");
            }
            else
            {
                Console.WriteLine("Debe contener letras mayúsculas y minúsculas");
            }
        }
    }
}
