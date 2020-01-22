using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Catalogo que almacena los tipos de doctores
    /// </summary>
    public class TipoDoctor
    {
        /// <summary>
        /// Identificador unico del tipo de doctor
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombre del tipo de doctor
        /// </summary>
        public string Nombre { get; set; }
    }
}
