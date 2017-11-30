using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTrgovina.Models.Domain
{
    public class Review
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public int Ocjena { get; set; }

        
        [StringLength(255)]
        [Display(Name = "Naziv artikla")]
        public string Opis { get; set; }

        
        public int ArtiklId { get; set; }

        public virtual Artikl Artikl { get; set; }

        [Display(Name = "Korisnik")]
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}