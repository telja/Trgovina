using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTrgovina.Models.DTO
{
    public class ArtiklDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        public string Opis { get; set; }

        [Required]
        public int Kolicina { get; set; }

        
        [Required]
        public DateTime DatumUnosa { get; set; }

        [Required]
        public decimal Cjena { get; set; }
    }
}