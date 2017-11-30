using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebTrgovina.Mapper.Domain_VM;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels;
using WebTrgovina.Models.ViewModels.ArtiklViewModels;
using WebTrgovina.Models.ViewModels.ArtiklViewModels.Admin;

namespace WebTrgovina.Controllers.Artikls.Manager
{
    public class ArtiklsManager
    {
        public static  List<ArtiklVM> GetAllArtikls()
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikls = _context.Artikli.ToList();
                var artiklsVM = Domain_VM_Mapper.MapListArtikl(artikls);
                return artiklsVM;
            }
        }

        public static void CreateArtikl(ArtiklVM artiklVM)
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikl = Domain_VM_Mapper.MapArtikl(artiklVM);
                _context.Artikli.Add(artikl);
                _context.SaveChanges();
            }
        }

        public static ArtiklVM GetArtiklById(int id)
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikl = _context.Artikli.FirstOrDefault(a => a.Id == id);
                var artiklVM = Domain_VM_Mapper.MapArtikl(artikl);
                return artiklVM;
            }
        }




        public static ArtiklDetailsVM GetArtiklDetailsById(int id)
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikl = _context.Artikli.FirstOrDefault(a => a.Id == id);
                var artiklVM = Domain_VM_Mapper.MapArtikl(artikl);
                var reviews = _context.Reviews.Where(r=>r.ArtiklId==id).ToList();
                var reviewsVM = Domain_VM_Mapper.MapListReview(reviews);

                var artiklDetailsVM = new ArtiklDetailsVM();
                artiklDetailsVM.ArtiklVM = artiklVM;
                artiklDetailsVM.ReviewsVM = reviewsVM;

                return artiklDetailsVM;
            }
        }
        public static void EditArtikl(ArtiklVM artiklVM)
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikl = Domain_VM_Mapper.MapArtikl(artiklVM);
                _context.Entry(artikl).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public static void DeleteArtikl(int id)
        {
            using (var _context = new ApplicationDbContext())
            {
                var artikl = _context.Artikli.FirstOrDefault(a => a.Id == id);
                _context.Artikli.Remove(artikl);
                _context.SaveChanges();
            }
        }
    }
}