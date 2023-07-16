using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class CabPedido
    {
        public CabPedido()
        {
            DetPedidos = new HashSet<DetPedido>();
        }

        public int NumVta { get; set; }
        public DateTime? Fecha { get; set; }
        public string CodCli { get; set; }
        public decimal? Total { get; set; }
        public int Estado { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
        public virtual ICollection<DetPedido> DetPedidos { get; set; }
    }
}
