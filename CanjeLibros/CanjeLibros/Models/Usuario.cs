using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public class Usuario
    {
        public string ID { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string location { get; set; }
        public string phone { get; set; }
    }


}