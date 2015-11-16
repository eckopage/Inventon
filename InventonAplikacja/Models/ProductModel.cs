using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventonAplikacja.Models
{
    public class ProductModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Nazwa produktu musi mieć przynajmniej {2} znaków i nie więcej niż {0}.", MinimumLength = 1)]
        [Display(Name = "Nazwa produktu")]
        public string ProduktNazwa { get; set; }

        [Display(Name = "Opis produktu")]
        public string ProduktOpis { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Proszę wpisać poprawnie cenę.")]
        [Display(Name = "Cena")]
        public string ProduktCena { get; set; }

        public DateTime? ProduktDataDodania { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Proszę wybrać producenta z listy.")]
        [Display(Name = "Producent")]
        public int? ProduktProducentId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Proszę wybrać kategorię z listy.")]
        [Display(Name = "Kategoria")]
        public int KategoriaId { get; set; }

        //public byte[] Obrazek { get; set; }

        public HttpPostedFileBase Obrazek { get; set; }
    }
}