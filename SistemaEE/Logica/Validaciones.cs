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
        public static bool ValidarCuilCuit(string cuilCuit)
        {
            // Validar que el CUIL | CUIT tenga 11 dígitos
            if (cuilCuit.Length != 11)
            {
                return false;
            }

            // Validar que el CUIL | CUIT solo contenga números
            if (!Regex.IsMatch(cuilCuit, @"^\d+$"))
            {
                return false;
            }

            bool rv = false;
            int verificador;
            int resultado = 0;
            string cuit_nro = cuilCuit.Replace("-", string.Empty);
            string codes = "6789456789";
            long cuit_long = 0;

            if (long.TryParse(cuit_nro, out cuit_long))
            {
                verificador = int.Parse(cuit_nro[cuit_nro.Length - 1].ToString());
                int x = 0;
                while (x < 10)
                {
                    int digitoValidador = int.Parse(codes.Substring((x), 1));
                    int digito = int.Parse(cuit_nro.Substring((x), 1));
                    int digitoValidacion = digitoValidador * digito;
                    resultado += digitoValidacion;
                    x++;
                }
                resultado = resultado % 11;
                rv = (resultado == verificador);
            }

            return rv;
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
