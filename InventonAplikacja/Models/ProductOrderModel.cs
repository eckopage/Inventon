using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventonAplikacja.Models
{
    public class ProductOrderModel
    {
        public int id { get; set; }
        public int ZamowienieId { get; set; }
        public int ProduktId { get; set; }
        public int Ilosc { get; set; }
        public string CenaSuma { get; set; }
    }
}