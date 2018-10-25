using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace CanjeLibros.Models
{
    public enum Genre
    {
        [Description("Arte")]
        ART = 0,
        [Description("Biografía")]
        BIOGRAPHY = 1,
        [Description("Negocios")]
        BUSINESS = 2,
        [Description("Infantiles")]
        CHILDREN = 3,
        [Description("Clásicos")]
        CLASSICS = 4,
        [Description("Libros de cocina")]
        COOKBOOKS = 5,
        [Description("Comics")]
        COMICS = 6,
        [Description("Fantasía")]
        FANTASY = 7,
        [Description("Ficción")]
        FICTION = 8,
        [Description("Novelas Gráficas")]
        GRAPHIC_NOVELS = 9,
        [Description("Ficción histórica")]
        HISTORICAL_FICTION = 10,
        [Description("Historia")]
        HISTORY = 11,
        [Description("Misterio")]
        MYSTERY = 12,
        [Description("Romance")]
        ROMANCE = 13,
        [Description("Juveniles")]
        YOUNG_ADULT = 14,
        [Description("Autoayuda")]
        SELF_HELP = 15,
        [Description("Ciencia ficción")]
        SCIENCE_FICTION = 16,   
    }
}