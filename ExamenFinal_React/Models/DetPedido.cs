using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class DetPedido
    {
        public int NumVta { get; set; }
        public int CodLibro { get; set; }
        public short Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Estado { get; set; }

        public virtual Libro CodLibroNavigation { get; set; }
        public virtual CabPedido NumVtaNavigation { get; set; }
    }
}
