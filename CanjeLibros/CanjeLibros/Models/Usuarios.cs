namespace CanjeLibros.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int ID { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public string location { get; set; }

        [Required]
        public string phone { get; set; }
    }
}
