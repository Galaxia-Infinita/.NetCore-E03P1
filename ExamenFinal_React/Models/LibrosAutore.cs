using System;
using System.Collections.Generic;

#nullable disable

namespace ExamenFinal_React.Models
{
    public partial class LibrosAutore
    {
        public int CodAutor { get; set; }
        public int CodLibro { get; set; }

        public virtual Autore CodAutorNavigation { get; set; }
        public virtual Libro CodLibroNavigation { get; set; }
    }
}
