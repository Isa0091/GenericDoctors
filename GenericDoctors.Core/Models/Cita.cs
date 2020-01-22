using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDoctors.Core.Enum;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad que representa a una cita 
    /// </summary>
    public class Cita
    {
        /// <summary>
        /// Identificador unico de la cita
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Fecha en la que esta programada la cita
        /// </summary>
        public DateTime FechaCita { get; set; }

        /// <summary>
        /// Fecha en la que se ingreso la cita
        /// </summary>
        public DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Fecha en que la cita se dio por cerrada
        /// </summary>
        public DateTime? FechaCitaCerro { get; set; }

        /// <summary>
        /// Observacion se le realizo a la cita
        /// </summary>
        public string Observacion { get; set; }

        /// <summary>
        /// Orden de importancia de la cita
        /// </summary>
        public int Orden { get; set; }

        /// <summary>
        /// Codigo de la <see cref="CategoriaEnfermedad"/> a la que pertenece esta cita
        /// </summary>
        public int IdCategoriaEnfermedad { get; set; }

        /// <summary>
        /// Codigo del <see cref="Models.Responsable"/> que esta asignado a esta cita
        /// </summary>
        public int IdResponsable { get; set; }

        /// <summary>
        /// Codigo del <see cref="Paciente"/> que esta asignado a esta cita
        /// </summary>
        public int IdPaciente { get; set; }

        /// <summary>
        /// Doctor encargado de esta cita
        /// </summary>
        public Responsable Responsable { get; set; }

        /// <summary>
        /// Paciente asignado a la cita
        /// </summary>
        public Paciente Paciente { get; set; }

        /// <summary>
        /// Categoria de la enfermedad de la cita
        /// </summary>
        public Categoria Categoria { get; set; }

        /// <summary>
        /// Especificaciones de los gastos que se realizaran
        /// </summary>
        public List<SubCategoria> SubCategorias { get; set; }

        /// <summary>
        /// Tipo de pago que prefirio el paciente
        /// </summary>
        public TipoPago? TipoPago { get; set; }

        /// <summary>
        /// Historial de las sesiones que se han llevado a cabo 
        /// </summary>
        public List<SesionCita> SesionCita { get; set; }

        /// <summary>
        /// Archivos de la cita
        /// </summary>
        public List<Multimedia> ArchivosCita { get; set; }

        /// <summary>
        /// Precio total de la consulta
        /// </summary>
        public decimal? Precio { get; set;}

    }
}
