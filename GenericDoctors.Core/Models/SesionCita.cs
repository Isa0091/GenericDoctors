using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad que representa una sesion que se le realiza a una cita
    /// </summary>
    public class SesionCita
    {
        /// <summary>
        /// Codigo de la sesion
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Fecha en que se realizo la sesion
        /// </summary>
        public DateTime FechaSesion { get; set; }

        /// <summary>
        /// Observaciones que se realizaron en esta sesion
        /// </summary>
        public string Observacion { get; set; }

        /// <summary>
        /// Codigo de la cita a la que pertenece esta sesion
        /// </summary>
        public int IdCita { get; set; }
        /// <summary>
        /// Codigo del abono que se le realizo a la cita
        /// </summary>
        public int? IdAbono { get; set; }

        /// <summary>
        /// Abono que se le realizo a la cita
        /// </summary>
        public Abono Abono { get; set; }

        /// <summary>
        /// Cita a la que pertenece esta sesion
        /// </summary>

        public Cita Cita { get; set; }

    }
}
