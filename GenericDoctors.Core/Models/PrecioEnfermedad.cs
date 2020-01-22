using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Catalogo de precios de una enfemerdad
    /// </summary>
    public class PrecioEnfermedad
    {
        /// <summary>
        /// Identificador unico del precio
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Precio de la enfermedad
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Codigo de la enfermedad
        /// </summary>
        public int IdEnfermedad { get; set; }

        /// <summary>
        /// Enfermedad a la que pertenece el precio
        /// </summary>
        public SubCategoria Enfermedad { get; set; }
    }
}
