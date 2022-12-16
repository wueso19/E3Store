using System;

namespace ValidateNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool isValid;
            do
            {
                Console.Write("Porfavor ingresa un Nombre: ");
                name = Console.ReadLine();
                if (IsValidName(name))
                {
                    Console.WriteLine("Nombre Válido");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Nombre Inválido");
                    isValid = true;

                }
            } while (isValid);
        }

        public static bool IsValidName(string name)
        {

            // Separa el nombre en términos
            string[] terminos = name.Split(' ');

            // Verifica que haya solo dos o tres términos
            if (terminos.Length != 2 && terminos.Length != 3)
            {
                return false;
            }

            // Verifica que el apellido empiece con mayúscula
            if (!char.IsUpper(terminos[terminos.Length - 1][0]))
            {
                return false;
            }

            // Verifica que el primer término sea una inicial o una palabra completa
            if (terminos[0].Length == 2)
            {
                // Verifica que el primer término sea una inicial con punto
                if (!terminos[0].EndsWith("."))
                {
                    return false;
                }

                // Verifica que la inicial esté en mayúscula
                if (!char.IsUpper(terminos[0][0]))
                {
                    return false;
                }

                // Verifica que que haya 3 términos y  mayúscula con punto
                if (terminos.Length == 3)
                {
                    //Verifica que el segundo término sea una inicial
                    if (terminos[1].Length != 2)
                    {
                        return false;
                    }

                    if (!terminos[1].EndsWith("."))
                    {
                        return false;
                    }

                    if (!char.IsUpper(terminos[1][0]))
                    {
                        return false;
                    }
                }

            }
            else
            {
                // Verifica que el primer término sea una palabra completa
                if (terminos[0].Length < 2)
                {
                    return false;
                }

                // Verifica que la palabra completa empiece en mayúscula
                if (!char.IsUpper(terminos[0][0]))
                {
                    return false;
                }

                // Verifica que el primer término tenga un punto
                if (terminos[0].EndsWith("."))
                {
                    return false;
                }

            }

            // Verifica que el segundo término sea una inicial o una palabra completa
            if (terminos[1].Length == 1)
            {
                // Verifica que el segundo término sea una inicial con punto
                if (!terminos[1].EndsWith("."))
                {
                    return false;
                }

                // Verifica que la inicial esté en mayúscula
                if (!char.IsUpper(terminos[1][0]))
                {
                    return false;
                }
            }
            else
            {
                // Verifica que el segundo término sea una palabra completa
                if (terminos[1].Length < 2)
                {
                    return false;
                }

                // Verifica que la palabra completa empiece en mayúscula
                if (!char.IsUpper(terminos[1][0]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
