using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public class Usuario
    {
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "Por favor ingrese Alias")]
        [MaxLength(20), MinLength(6, ErrorMessage = "El alias debe tener como mínimo seis caracteres"), RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "El alias sólo puede contener letras y/o números.")]
        public string userName { get; set; }
        [Required]
        [MaxLength(60)]
        public string name { get; set; }
        [Required]
        [MaxLength(60)]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [MaxLength(15), MinLength(6)]
        public string location { get; set; }
        [Required]
        [Phone]
        public string phone { get; set; }
    }
}