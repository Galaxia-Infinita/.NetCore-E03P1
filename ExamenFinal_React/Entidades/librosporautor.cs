using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_React.Entidades
{
    public class librosporautor
    {
        public int CodLibro { get; set; }
        public string NomLibro { get; set; }
        public decimal? PreLibro { get; set; }
        public int? StkLibro { get; set; }

        public DateTime? FecNacAut { get; set; }
        public string NomPais { get; set; }
        public decimal? totautor { get; set; }
    }
}
