using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SistemaEE.Formularios.Entrada;

namespace SistemaEE.Clases
{
    internal class Validaciones
    {
        public static bool ValidarCuit(string cuit)
        {
            // Validar que el CUIT tenga al menos 10 dígitos y como máximo 11 dígitos
            if (cuit.Length < 10 || cuit.Length > 11)
            {
                return false;
            }

            // Validar que el CUIT solo contenga números
            if (!Regex.IsMatch(cuit, @"^\d+$"))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarNombre(string nombre)
        {
            // Validar que el nombre solo contenga letras y un único caracter espacio
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+( [a-zA-Z]+)?$"))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarEmail(string email)
        {
            // Utilizar expresión regular para validar el formato del correo electrónico
            // Esta expresión regular permite una amplia variedad de formatos de correo electrónico válidos
            // pero no garantiza que sea una dirección de correo electrónico real y existente
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
