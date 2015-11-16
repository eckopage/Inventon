using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventonAplikacja.Models
{
    public class OrderModel
    {
        public int id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int StatusZamowieniaId { get; set; }
        public DateTime DataPrzyjecia { get; set; }
    }
}