using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad para representar los abonos que se le pueden realizar a una cita
    /// </summary>
    public class Abono
    {
        /// <summary>
        /// Identificador unico del abono
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Fecha en que se presenta el abono
        /// </summary>
        public DateTime FechaAbono { get; set; }

        /// <summary>
        /// Cantidad abonada
        /// </summary>
        public double CantidadAbonada { get; set; }


    }
}
