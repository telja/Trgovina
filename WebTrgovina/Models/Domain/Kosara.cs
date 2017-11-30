using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTrgovina.Models.Domain
{
    public class Kosara
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ArtiklId { get; set; }
        public virtual Artikl Artikl { get; set; }

        public DateTime DatumNarudzbe { get; set; }
    }
}