using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels.ArtiklViewModels;

namespace WebTrgovina.Models.ViewModels
{
    public class ReviewVM
    {
        public int Id { get; set; }

        [Range(1,5)]
        public int Ocjena { get; set; }

        [StringLength(255)]
        [Display(Name = "Opis artikla")]
        public string Opis { get; set; }


        [Display(Name = "Artikl")]
        public int ArtiklVMId { get; set; }
        public  ArtiklVM ArtiklVM { get; set; }
        [Display(Name = "Korisnik")]
        public int ApplicationUserId { get; set; }
        public  ApplicationUser User { get; set; }
    }
}