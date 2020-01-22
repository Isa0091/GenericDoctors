using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Enum
{
    /// <summary>
    /// Contenedor de las formas de pago del sistema
    /// </summary>

    public enum TipoPago
    {
        /// <summary>
        /// metodo de pago por cuotas 
        /// </summary>
        Cuotas = 2,

        /// <summary>
        /// solo viene a una revicion periodica
        /// </summary>
        Revision = 3

    }

    /// <summary>
    /// Representa los generos que se manejaran en el sistema
    /// </summary>
    public enum Genero
    {
        /// <summary>
        /// Genero masculino
        /// </summary>
        Masculino = 1,

        /// <summary>
        /// Genero femenino
        /// </summary>
        Femenino = 2
    }

    /// <summary>
    /// Indica que tipo de archivo puede ser una multimedia
    /// </summary>
    public enum TipoMultimedia
    {
        /// <summary>
        /// la multimedia es una imagen
        /// </summary>
        Imagen = 1,

        /// <summary>
        /// indica que la multimedia es un video
        /// </summary>
        Video = 2,

        /// <summary>
        /// Indica que la multimedia es un archivo
        /// </summary>
        Archivo = 3
    }
}
