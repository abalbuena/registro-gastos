using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegistroGastos.Models.Categoria;

namespace RegistroGastos.Models.Gasto
{
    /// <summary>
    /// Modelo de Gasto.
    /// </summary>
    public class MovimientoModel
    {
        /// <summary>
        /// Tipo de gasto.
        /// </summary>
        public TipoGasto Tipo { get; set; }

        /// <summary>
        /// Descripción del gasto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Código de categoría.
        /// </summary>
        public int CodigoCategoria { get; set; }

        /// <summary>
        /// Categoría del casto.
        /// </summary>
        public CategoriaModel Categoria { get; set; }
    }
}