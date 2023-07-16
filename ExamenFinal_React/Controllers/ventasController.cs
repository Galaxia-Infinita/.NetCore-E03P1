using ExamenFinal_React.Entidades;
using ExamenFinal_React.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ventasController : ControllerBase
    {
        BDVENTALIBROSContext bd = new BDVENTALIBROSContext();

        [HttpGet("Libros")]
        public IEnumerable<Libro> ListarLibro()
        {
            return bd.Libros.ToList();
        }

        [HttpGet("Autores")]
        public IEnumerable<Autore> ListarAutores()
        {
            return bd.Autores.ToList();
        }

        [HttpGet("VentasLibro/{nomlib}")]
        public IEnumerable<ventasporlibro> ListarVentas(string nomlib)
        {
            var query = from a in bd.DetPedidos
                        join b in bd.Libros on a.CodLibro equals b.CodLibro
                        where b.NomLibro.Equals(nomlib)
                        group new {a,b}
                        by new {a.NumVta,a.CodLibro,b.NomLibro,a.Precio,a.Cantidad,a.Estado,b.StkLibro,b.Edicion} into gidat
                        select new ventasporlibro
                        {
                            NumVta = gidat.Key.NumVta,
                            CodLibro = gidat.Key.CodLibro,
                            NomLibro = gidat.Key.NomLibro,
                            Cantidad = gidat.Key.Cantidad,
                            Precio = gidat.Key.Precio,
                            Estado = gidat.Key.Estado,

                            StkLibro = gidat.Key.StkLibro,
                            Edicion = gidat.Key.Edicion,
                            total=gidat.Sum(x=>x.a.Precio*x.a.Cantidad)
                        };
            return query.ToList();
        }

        [HttpGet("LibrosAutor/{nomAutor}")]
        public IEnumerable<librosporautor> ListarAutor(string nomAutor)
        {
            var query = from a in bd.Libros
                        join b in bd.LibrosAutores on a.CodLibro equals b.CodLibro
                        join c in bd.Autores on b.CodAutor equals c.CodAutor
                        join d in bd.Pais on c.CodPais equals d.CodPais
                        where c.NomAutor.Equals(nomAutor)
                        group new { a, b, c,d }
                        by new { a.CodLibro, a.NomLibro, a.PreLibro, a.StkLibro, c.FecNacAut, d.NomPais } into gidat
                        select new librosporautor
                        {
                            CodLibro = gidat.Key.CodLibro,
                            NomLibro = gidat.Key.NomLibro,
                            PreLibro = gidat.Key.PreLibro,
                            StkLibro = gidat.Key.StkLibro,

                            FecNacAut=gidat.Key.FecNacAut,
                            NomPais=gidat.Key.NomPais,
                            totautor=gidat.Sum(x=>x.a.PreLibro*x.a.StkLibro)
                        };
                        
            return query.ToList();
        }

    }
}
