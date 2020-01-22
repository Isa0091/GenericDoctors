using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDoctors.Core.Enum;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad que representa a un paciente
    /// </summary>
    public class Paciente
    {
        /// <summary>
        /// Identificador unico del paciente
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombres del paciente
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Apellidos del paciente
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Fecha en la que nacio el paciente
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Telefono del paciente
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Telefono celular del paciente
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Direccion del paciente
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Genero del paciente
        /// </summary>
        public Genero Genero { get; set; }

        /// <summary>
        /// Observaciones que se le han realizado al paciente
        /// </summary>
        public string Observaciones { get; set; }

        /// <summary>
        /// Alergias que presenta el paciente Ej: medicamentos
        /// </summary>
        public string Alergias { get; set; }

        /// <summary>
        /// Lista de citas que tiene el agente
        /// </summary>
        public List<Cita> CitasPaciente { get; set; }

        /// <summary>
        /// Regresa la edad del paciente
        /// </summary>
        /// <returns></returns>
        public int GetEdad()
        {
            DateTime fechaActual = DateTime.Now;

            int diferenciaAnios = DateTime.Now.Year - FechaNacimiento.Year;

            //Si ya cumplio años
            if (FechaNacimiento.Month <= fechaActual.Month && FechaNacimiento.Day < fechaActual.Day)
                return diferenciaAnios;

            return diferenciaAnios - 1;
        }
    }
}
