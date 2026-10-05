using System;

namespace Ganaderia.Core.Modelos
{
    public class Rancho
    {
        /// <summary>UUID en texto: permite que la tablet cree registros sin chocar con los del escritorio.</summary>
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        /// <summary>Siempre en UTC.</summary>
        public DateTime CreadoEn { get; set; }

        /// <summary>Siempre en UTC. Sirve para saber qué cambió al sincronizar.</summary>
        public DateTime ActualizadoEn { get; set; }
    }
}
