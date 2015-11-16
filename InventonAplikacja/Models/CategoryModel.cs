using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventonAplikacja.Models
{
    public class CategoryModel
    {
        public int id { get; set; }
        public string KategoriaNazwa { get; set; }
        public string KategoriaOpis { get; set; }
        public System.DateTime KategoriaDataDodania { get; set; }
    }
}