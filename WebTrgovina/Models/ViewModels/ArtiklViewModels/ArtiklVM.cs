using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTrgovina.Models.ViewModels.ArtiklViewModels
{
    public class ArtiklVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv artikla.")]
        [StringLength(255)]
        [Display(Name = "Naziv artikla")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Unesite naziv opisa.")]
        [Display(Name = "Opis artikla")]
        [DataType(DataType.MultilineText)]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Unesite količinu.")]
        [Display(Name = "Količina")]
        public int Kolicina { get; set; }
        

        [Required]
        [Display(Name = "Datum unosa")]
        public DateTime DatumUnosa { get; set; }

        [Required]
        [Display(Name = "Cijena")]
        public decimal Cjena { get; set; }
    }
}