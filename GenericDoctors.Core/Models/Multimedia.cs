using GenericDoctors.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad contenedora de todas las multimedias a usar en el sistema
    /// </summary>
    public class Multimedia
    {
        /// <summary>
        /// Identificador unico de la multimedia
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombre del archivo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Indica el tipo de multimedia 
        /// </summary>
        public TipoMultimedia TipoArchivo { get; set; }

        /// <summary>
        /// Tipo de archivo en texto
        /// </summary>
        public string TipoArchivoTexto { get { return TipoArchivo.ToString(); }  }

        /// <summary>
        /// El archivo convertido a un byte array
        /// </summary>
        public byte[] Contenido { get; set; }
    }
}
