using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad que representa a un doctor
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Identificador unico del doctor
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombres del doctor
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Apellidos del doctor
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Fecha en la que nacio el doctor
        /// </summary>
        public string FechaNacimiento { get; set; }

        /// <summary>
        /// Telefono del doctor
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Telefono celular del doctor
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Genero del doctor 
        /// </summary>
        public string Genero { get; set; }
       
        /// <summary>
        /// Indica si el doctor esta activo o inactivo
        /// </summary>
        public bool Activo { get; set; }

        /// <summary>
        /// Codigo identificador del consultorio
        /// </summary>
        public int IdConsultorio { get; set; }

        /// <summary>
        /// Consultorio al que pertenece el doctor
        /// </summary>
        public Consultorio Consultorio { get; set; }

        /// <summary>
        /// Tipo de doctor al que pertenece este doctor
        /// </summary>
        public TipoDoctor TipoDoctor { get; set; }

    }
}
