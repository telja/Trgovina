using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.DTO;

namespace WebTrgovina.Mapper.Domain_DTO
{
    public class Domain_DTO_Mapper
    {
        #region Artikl
        public static Artikl MapArtikl(ArtiklDTO artiklDTO)
        {
            return new Artikl
            {
                Id = artiklDTO.Id,
                Naziv = artiklDTO.Naziv,
                Opis = artiklDTO.Opis,
                Kolicina = artiklDTO.Kolicina,
                DatumUnosa = artiklDTO.DatumUnosa,
                Cjena = artiklDTO.Cjena
            };
        }

        public static ArtiklDTO MapArtikl(Artikl artikl)
        {
            return new ArtiklDTO
            {
                Id = artikl.Id,
                Naziv = artikl.Naziv,
                Opis = artikl.Opis,
                Kolicina = artikl.Kolicina,
                DatumUnosa = artikl.DatumUnosa,
                Cjena = artikl.Cjena
            };
        }

        #endregion
    }
}