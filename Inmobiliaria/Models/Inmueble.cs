using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Display(Name = "Descripción")]
        public String descripcion { get; set; }

        [Display(Name = "Imagen")]
        public String imagen { get; set; }

        [Display(Name = "Dirección")]
        public String direccion { get; set; }

        [Display(Name = "Barrio")]
        public String barrio { get; set; }

        [Display(Name = "Ambientes")]
        public int ambientes { get; set; }

        [Display(Name = "Baños")]
        public int banos { get; set; }

        [Display(Name = "Cochera")]
        public int cochera { get; set; }

        [Display(Name = "Precio")]
        public float precio { get; set; }

    }
}
