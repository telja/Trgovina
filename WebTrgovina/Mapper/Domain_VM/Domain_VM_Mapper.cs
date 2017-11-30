using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels;
using WebTrgovina.Models.ViewModels.ArtiklViewModels;

namespace WebTrgovina.Mapper.Domain_VM
{
    public class Domain_VM_Mapper
    {
        #region Artikl
        public static Artikl MapArtikl(ArtiklVM artiklVM)
        {
            return new Artikl
            {
                Id = artiklVM.Id,
                Naziv = artiklVM.Naziv,
                Opis = artiklVM.Opis,
                Kolicina = artiklVM.Kolicina,
                DatumUnosa = artiklVM.DatumUnosa,
                Cjena = artiklVM.Cjena
            };
        }

        public static ArtiklVM MapArtikl(Artikl artikl)
        {
            return new ArtiklVM
            {
                Id = artikl.Id,
                Naziv = artikl.Naziv,
                Opis = artikl.Opis,
                Kolicina = artikl.Kolicina,
                DatumUnosa = artikl.DatumUnosa,
                Cjena = artikl.Cjena
            };
        }


        public static List<Artikl> MapListArtikl(List<ArtiklVM> artikliVM)
        {
            var ListArtikls = new List<Artikl>();

            foreach (var artiklVM in artikliVM)
            {
                var artikl = new Artikl
                {
                    Id = artiklVM.Id,
                    Naziv = artiklVM.Naziv,
                    Opis = artiklVM.Opis,
                    Kolicina = artiklVM.Kolicina,
                    DatumUnosa = artiklVM.DatumUnosa,
                    Cjena = artiklVM.Cjena
                };

                ListArtikls.Add(artikl);
            }

            return ListArtikls;
        }

        public static List<ArtiklVM> MapListArtikl(List<Artikl> artikli)
        {
            var ListArtikls = new List<ArtiklVM>();

            foreach (var artikl in artikli)
            {
                var artiklVM = new ArtiklVM
                {
                    Id = artikl.Id,
                    Naziv = artikl.Naziv,
                    Opis = artikl.Opis,
                    Kolicina = artikl.Kolicina,
                    DatumUnosa = artikl.DatumUnosa,
                    Cjena = artikl.Cjena
                };

                ListArtikls.Add(artiklVM);
            }

            return ListArtikls;
        }

        #endregion

        
        #region Review
        public static Review MapReview(ReviewVM reviewVM)
        {
            return new Review
            {
                Id = reviewVM.Id,
                Ocjena = reviewVM.Ocjena,
                Opis = reviewVM.Opis,
                ArtiklId = reviewVM.ArtiklVMId,
                ApplicationUserId = reviewVM.ApplicationUserId
            };
        }

        public static ReviewVM MapReview(Review review)
        {
            return new ReviewVM
            {
                Id = review.Id,
                Ocjena = review.Ocjena,
                Opis = review.Opis,
                ArtiklVMId = review.ArtiklId,
                ApplicationUserId = review.ApplicationUserId
            };
        }


        public static List<Review> MapListReview(List<ReviewVM> reviewiVM)
        {
            var listReviews = new List<Review>();

            foreach (var reviewVM in reviewiVM)
            {
                var review = new Review
                {
                    Id = reviewVM.Id,
                    Ocjena = reviewVM.Ocjena,
                    Opis = reviewVM.Opis,
                    ArtiklId = reviewVM.ArtiklVMId,
                    ApplicationUserId = reviewVM.ApplicationUserId
                };

                listReviews.Add(review);
            }

            return listReviews;
        }

        public static List<ReviewVM> MapListReview(List<Review> reviews)
        {
            var listReviews = new List<ReviewVM>();

            foreach (var review in reviews)
            {
                var ReviewVM = new ReviewVM
                {
                    Id = review.Id,
                    Ocjena = review.Ocjena,
                    Opis = review.Opis,
                    ArtiklVMId = review.ArtiklId,
                    ApplicationUserId = review.ApplicationUserId
                };

                listReviews.Add(ReviewVM);
            }

            return listReviews;
        }

        #endregion


        #region Kosara
        public static Kosara MapKosara(KosaraVM kosaraVM)
        {
            return new Kosara
            {
                Id = kosaraVM.Id,
                DatumNarudzbe = kosaraVM.DatumNarudzbe,
                ArtiklId = kosaraVM.ArtiklId,
                ApplicationUserId = kosaraVM.ApplicationUserId
            };
        }

        public static KosaraVM MapKosara(Kosara kosara)
        {
            return new KosaraVM
            {
                Id = kosara.Id,
                DatumNarudzbe = kosara.DatumNarudzbe,
                ArtiklId = kosara.ArtiklId,
                ApplicationUserId = kosara.ApplicationUserId
            };
        }


        public static List<Kosara> MapListKosara(List<KosaraVM> kosareVM)
        {
            var listKosaras = new List<Kosara>();

            foreach (var kosaraVM in kosareVM)
            {
                var kosara = new Kosara
                {
                    Id = kosaraVM.Id,
                    DatumNarudzbe = kosaraVM.DatumNarudzbe,
                    ArtiklId = kosaraVM.ArtiklId,
                    ApplicationUserId = kosaraVM.ApplicationUserId
                };

                listKosaras.Add(kosara);
            }

            return listKosaras;
        }

        public static List<KosaraVM> MapListKosara(List<Kosara> kosare)
        {
            var listKosaras = new List<KosaraVM>();

            foreach (var kosara in kosare)
            {
                var kosaraVM = new KosaraVM
                {
                    Id = kosara.Id,
                    DatumNarudzbe = kosara.DatumNarudzbe,
                    ArtiklId = kosara.ArtiklId,
                    ApplicationUserId = kosara.ApplicationUserId
                };

                listKosaras.Add(kosaraVM);
            }

            return listKosaras;
        }

        #endregion
    }
}