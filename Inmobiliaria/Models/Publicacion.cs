using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Publicacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [ForeignKey("Inmueble")]
        public int miIdInmuebe { get; set; } 
        public Inmueble inmueble { get; set; }

        //public int IdInmueble { get; set; }
        public string fechaDePublicacion { get; set; }

        public int cantidadDeVisitas { get; set; }

        public TipoOperacion operacion { get; set; }
    }
}
