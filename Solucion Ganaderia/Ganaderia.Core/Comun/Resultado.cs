namespace Ganaderia.Core.Comun
{
    /// <summary>
    /// Respuesta de una operación de negocio: si salió bien o el mensaje para el usuario.
    /// Los servicios devuelven esto en lugar de lanzar excepciones por errores esperados
    /// (validaciones, duplicados), así la vista solo revisa <see cref="Exito"/>.
    /// </summary>
    public class Resultado
    {
        public bool Exito { get; }
        public string Mensaje { get; }

        protected Resultado(bool exito, string mensaje)
        {
            Exito = exito;
            Mensaje = mensaje;
        }

        public static Resultado Ok() => new Resultado(true, null);

        public static Resultado Error(string mensaje) => new Resultado(false, mensaje);
    }

    /// <summary>
    /// Igual que <see cref="Resultado"/>, pero además trae el valor producido (p. ej. el registro creado).
    /// </summary>
    public class Resultado<T> : Resultado
    {
        public T Valor { get; }

        private Resultado(bool exito, string mensaje, T valor) : base(exito, mensaje)
        {
            Valor = valor;
        }

        public static Resultado<T> Ok(T valor) => new Resultado<T>(true, null, valor);

        public static new Resultado<T> Error(string mensaje) => new Resultado<T>(false, mensaje, default(T));
    }
}
