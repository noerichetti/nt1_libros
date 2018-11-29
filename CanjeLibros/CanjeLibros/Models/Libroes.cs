namespace CanjeLibros.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Libroes
    {
        public int ID { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string editorial { get; set; }

        public TimeSpan publishingDate { get; set; }

        public int genre { get; set; }

        public string synopsis { get; set; }

        public int language { get; set; }

        public string photo { get; set; }
    }
}
