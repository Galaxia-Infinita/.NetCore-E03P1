using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class Pai
    {
        public Pai()
        {
            Autores = new HashSet<Autore>();
            Clientes = new HashSet<Cliente>();
        }

        public int CodPais { get; set; }
        public string NomPais { get; set; }

        public virtual ICollection<Autore> Autores { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
