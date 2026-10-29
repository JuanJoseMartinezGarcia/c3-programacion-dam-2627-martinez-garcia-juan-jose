namespace actividad_3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nueva contraseña (mínimo 8 caracteres, conteniendo letras mayúsculas y minúsculas):"); 
        string password = Console.ReadLine();

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
                Console.WriteLine("Repita la contraseña:");
                string repetida = Console.ReadLine();

                if (password == repetida)
                {
                    Console.WriteLine("Contraseña cambiada correctamente");
                }
                else
                {
                    Console.WriteLine("Las contraseñas no coinciden");
                }
            }
            else
            {
                Console.WriteLine("Debe contener letras mayúsculas y minúsculas");
            }
        }
    }
}