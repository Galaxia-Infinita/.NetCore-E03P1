using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class Autore
    {
        public Autore()
        {
            LibrosAutores = new HashSet<LibrosAutore>();
        }

        public int CodAutor { get; set; }
        public string NomAutor { get; set; }
        public int? CodPais { get; set; }
        public string EmailAutor { get; set; }
        public DateTime? FecNacAut { get; set; }

        public virtual Pai CodPaisNavigation { get; set; }
        public virtual ICollection<LibrosAutore> LibrosAutores { get; set; }
    }
}
