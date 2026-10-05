using System.Globalization;
using System.Text;

namespace Ganaderia.Core.Comun
{
    public static class Texto
    {
        /// <summary>
        /// Clave para comparar nombres sin importar mayúsculas, acentos ni espacios extra:
        /// "  Los  Álamos " y "los alamos" dan la misma clave ("LOS ALAMOS").
        /// Se usa en lugar de COLLATE NOCASE, que en SQLite solo ignora mayúsculas en letras sin acento.
        /// </summary>
        public static string Clave(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            var sb = new StringBuilder(texto.Length);
            bool espacioPendiente = false;
            foreach (char c in texto.Trim().Normalize(NormalizationForm.FormD))
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark)
                    continue;
                if (char.IsWhiteSpace(c))
                {
                    espacioPendiente = true;
                    continue;
                }
                if (espacioPendiente)
                {
                    sb.Append(' ');
                    espacioPendiente = false;
                }
                sb.Append(char.ToUpperInvariant(c));
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
