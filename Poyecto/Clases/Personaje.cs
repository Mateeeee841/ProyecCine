using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class Personaje
    {
        public Personaje()
        {

        }
        
        [Key]
        public int id { get; set; }

        public string nombre { get; set; }
        public string img { get; set; }
        public int edad { get; set; }
        public decimal peso { get; set; }
        public string historia { get; set; }
        public Tv? tv { get; set; }
    }
}
