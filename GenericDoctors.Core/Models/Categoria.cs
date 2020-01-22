using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad para catalogar los tipos de gastos que pueden sumar en una cita
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Identificador unico de la categoria 
        /// </summary>
        public int Codigo { get; set; }
        
        /// <summary>
        /// Nombre de la categoria
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Lista de especificaciones de este posible gasto
        /// </summary>
        public List<SubCategoria> SubCategorias { get; set; }

    }
}
