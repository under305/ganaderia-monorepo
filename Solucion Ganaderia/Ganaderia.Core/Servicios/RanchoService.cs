using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Ganaderia.Core.Comun;
using Ganaderia.Core.Datos;
using Ganaderia.Core.Modelos;

namespace Ganaderia.Core.Servicios
{
    /// <summary>
    /// Reglas de negocio de ranchos. Las vistas llaman a estos métodos y solo
    /// muestran el <see cref="Resultado"/>; nunca tocan la base directamente.
    /// </summary>
    public class RanchoService
    {
        public const int LongitudMaximaNombre = 100;
        public const int LongitudMaximaUbicacion = 200;

        private readonly RanchoRepository _repo;

        public RanchoService(RanchoRepository repo)
        {
            _repo = repo;
        }

        public Resultado<Rancho> Agregar(string nombre, string ubicacion)
        {
            nombre = Regex.Replace((nombre ?? "").Trim(), @"\s+", " ");
            ubicacion = (ubicacion ?? "").Trim();

            if (nombre.Length == 0)
                return Resultado<Rancho>.Error("El nombre del rancho es obligatorio.");
            if (nombre.Length > LongitudMaximaNombre)
                return Resultado<Rancho>.Error($"El nombre no puede pasar de {LongitudMaximaNombre} caracteres.");
            if (ubicacion.Length > LongitudMaximaUbicacion)
                return Resultado<Rancho>.Error($"La ubicación no puede pasar de {LongitudMaximaUbicacion} caracteres.");
            if (_repo.ExisteNombre(nombre))
                return Resultado<Rancho>.Error($"Ya existe un rancho llamado \"{nombre}\".");

            var ahora = DateTime.UtcNow;
            var rancho = new Rancho
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = nombre,
                Ubicacion = ubicacion.Length == 0 ? null : ubicacion,
                CreadoEn = ahora,
                ActualizadoEn = ahora,
            };
            _repo.Insertar(rancho);
            return Resultado<Rancho>.Ok(rancho);
        }

        public List<Rancho> Listar() => _repo.ObtenerTodos();
    }
}
