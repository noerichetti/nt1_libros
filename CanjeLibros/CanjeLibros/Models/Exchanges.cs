namespace CanjeLibros.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exchanges
    {
        public int ID { get; set; }

        public int idUser1 { get; set; }

        public int idUser2 { get; set; }

        public int idBook1 { get; set; }

        public int idBook2 { get; set; }

        public bool done { get; set; }
    }
}
