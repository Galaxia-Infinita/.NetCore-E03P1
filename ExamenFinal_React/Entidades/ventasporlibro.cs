using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_React.Entidades
{
    public class ventasporlibro
    {
        public int NumVta { get; set; }

        public int CodLibro { get; set; }
        public string NomLibro { get; set; }
        public short Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Estado { get; set; }

        public int? StkLibro { get; set; }
        public int? Edicion { get; set; }
        public decimal total { get; set; }
    }
}
