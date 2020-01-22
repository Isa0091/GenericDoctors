using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoctors.Core.Models
{
    /// <summary>
    /// Entidad para especificar los gastos que pueden ocurrir en una cita
    /// </summary>
    public class SubCategoria
    {
        /// <summary>
        /// Identificador unico de la subcategoria
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombre de la subcategoria
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Codigo de la subcategoria
        /// </summary>
        public int IdCategoriaEnfermedad { get; set; }

        /// <summary>
        /// Categoria a la que pertenece la subcategoria
        /// </summary>
        public Categoria CategoriaPadre { get; set; }

        /// <summary>
        /// Lista de precios que se pueden seleccionar para la subcategoria
        /// </summary>
        public List<PrecioEnfermedad> PreciosEnfermedad { get; set; }
    }
}
