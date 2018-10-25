using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public enum Language
    {
        [Description("Inglés")]
        ENGLISH = 0,
        [Description("Español")]
        SPANISH = 1,
        [Description("Alemán")]
        GERMAN = 2,
        [Description("Portugués")]
        PORTUGUESE = 3,
        [Description("Italiano")]
        ITALIAN = 4,
        [Description("Chino")]
        CHINESE = 5,
        [Description("Holandés")]
        DUTCH = 6,
        [Description("Japonés")]
        JAPANESE = 7,
        [Description("Francés")]
        FRENCH = 8,
    }
}