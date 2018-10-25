using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public class Exchange
    {
        public int ID { get; set; }
        public int idUser1 { get; set; }
        public int idUser2 { get; set; }
        public int idBook1 { get; set; }
        public int idBook2 { get; set; }
        public Boolean done { get; set; }

    }
}