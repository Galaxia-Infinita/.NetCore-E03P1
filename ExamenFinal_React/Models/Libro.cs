using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class Libro
    {
        public Libro()
        {
            DetPedidos = new HashSet<DetPedido>();
            LibrosAutores = new HashSet<LibrosAutore>();
        }

        public int CodLibro { get; set; }
        public string NomLibro { get; set; }
        public decimal? PreLibro { get; set; }
        public int? StkLibro { get; set; }
        public int? Edicion { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<DetPedido> DetPedidos { get; set; }
        public virtual ICollection<LibrosAutore> LibrosAutores { get; set; }
    }
}
