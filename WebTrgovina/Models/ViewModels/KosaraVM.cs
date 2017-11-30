using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels.ArtiklViewModels;

namespace WebTrgovina.Models.ViewModels
{
    public class KosaraVM
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ArtiklId { get; set; }
        public  ArtiklVM Artikl { get; set; }

        public DateTime DatumNarudzbe { get; set; }
    }
}