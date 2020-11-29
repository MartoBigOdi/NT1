using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Formulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        
        public int Id { get; set; }

        [Display(Name = "Nombre y Apellido")]
        public string nombre { get; set; }

        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Display(Name = "Telefono")]
        public string telefono{ get; set; }

        [Display(Name = "Mensaje")]
        public string mensaje { get; set; }

        [Display(Name = "Tipo de Operacion")]
        public TipoOperacion tipoOperacion { get; set; }

        [Display(Name = "Tipo de Contacto")]
        public string tipoContacto { get; set; }
    }
}
