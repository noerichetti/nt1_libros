using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public class Libro
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string editorial { get; set; }
        public TimeSpan publishingDate { get; set; }
        public Genre genre{ get; set; }
        public string synopsis { get; set; }
        public Language language { get; set; }
        public string photo { get; set; }
    }
}