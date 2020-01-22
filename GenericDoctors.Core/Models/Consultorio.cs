using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Representa la cuenta de un cliente
    /// </summary>
    public class Consultorio
    {
        /// <summary>
        /// Identificador unico del consultorio
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombre del consultorio
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Fecha en la que se ingreso el consultorio
        /// </summary>
        public DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Indica si el consultorio esta activo o no
        /// </summary>
        public bool Activa { get; set; }

        /// <summary>
        /// Duracion promedio de citas en minutos 
        /// </summary>
        public int PromedioCitaMinutos { get; set; }

        /// <summary>
        /// Codigo identificador del loco del consultorio
        /// </summary>
        public int? IdLogo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Logo del consultorio
        /// </summary>
        public Multimedia Logo { get; set; }
    }
}
