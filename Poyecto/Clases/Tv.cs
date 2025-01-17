using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class Tv
    {

        public Tv() {

        }
        //public Tv(string img , string titulo , DateOnly creacion, int estrellas )
        //{
        //   List<Personaje> socios = new List<Personaje>();
        //    this.img = img;
        //    this.titulo = titulo;
        //    this.creacion = creacion;
        //    this.estrellas = estrellas;
        //    this.socios = socios;
        //}

        [Key]
        public int id { get; set; }
        public string img { get; set; }
        public string titulo { get; set; }
        public string creacion { get; set; }
        public int estrellas { get; set; } //Opinion personal del 1 al 5
        public List<Personaje> socios { get; set; }
    }
}
