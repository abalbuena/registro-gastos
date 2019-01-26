using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroGastos.Models.Categoria
{
    /// <summary>
    /// Modelo de Categoría de gasto.
    /// </summary>
    public class CategoriaModel
    {
        /// <summary>
        /// Descripción de la categoría.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Código de la categoría.
        /// </summary>
        public int Codigo { get; set; }
        
        /// <summary>
        /// Nombre de la categoría.
        /// </summary>
        public string Nombre { get; set; }
    }
}