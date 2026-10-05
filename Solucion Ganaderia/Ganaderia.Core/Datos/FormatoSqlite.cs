using System;
using System.Globalization;

namespace Ganaderia.Core.Datos
{
    /// <summary>
    /// Conversión de tipos .NET al formato que guarda la base. La tablet (JavaScript)
    /// lee el mismo archivo, así que todo va en formatos estándar, nunca en ticks de .NET.
    /// </summary>
    internal static class FormatoSqlite
    {
        private const string FormatoFecha = "yyyy-MM-ddTHH:mm:ss.fffZ";

        /// <summary>Fecha → texto ISO-8601 en UTC (lo entiende <c>new Date(...)</c> en JS).</summary>
        public static string Fecha(DateTime fecha) =>
            fecha.ToUniversalTime().ToString(FormatoFecha, CultureInfo.InvariantCulture);

        public static DateTime LeerFecha(object valor) =>
            DateTime.Parse((string)valor, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);

        public static object Texto(string valor) => string.IsNullOrEmpty(valor) ? (object)DBNull.Value : valor;

        public static string LeerTexto(object valor) => valor == DBNull.Value ? null : (string)valor;
    }
}
