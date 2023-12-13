using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Categoria
    {
        public Categoria()
        {
            Subcategoria = new HashSet<Subcategoria>();
        }

        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Subcategoria> Subcategoria { get; set; }
    }
}
