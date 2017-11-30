using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebTrgovina.Mapper.Domain_VM;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels;

namespace WebTrgovina.Controllers.Reviews.Manager
{
    public class ReviewManager
    {

        public static List<ReviewVM> GetAllReviews()
        {
            using (var _context = new ApplicationDbContext())
            {
                var reviews = _context.Reviews.ToList();
                var reviewsVM = Domain_VM_Mapper.MapListReview(reviews);
                return reviewsVM;
            }
        }

        public static void CreateReview(ReviewVM reviewVM)
        {
            using (var _context = new ApplicationDbContext())
            {
                var review = Domain_VM_Mapper.MapReview(reviewVM);
                _context.Reviews.Add(review);
                _context.SaveChanges();
            }
        }

        public static ReviewVM GetReviewById(int id)
        {
            using (var _context = new ApplicationDbContext())
            {
                var review = _context.Reviews.FirstOrDefault(a => a.Id == id);
                var reviewVM = Domain_VM_Mapper.MapReview(review);
                return reviewVM;
            }
        }
        public static void EditReview(ReviewVM reviewVM)
        {
            using (var _context = new ApplicationDbContext())
            {
                var review = Domain_VM_Mapper.MapReview(reviewVM);
                _context.Entry(review).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public static void DeleteReview(int id)
        {
            using (var _context = new ApplicationDbContext())
            {
                var Review = _context.Reviews.FirstOrDefault(a => a.Id == id);
                _context.Reviews.Remove(Review);
                _context.SaveChanges();
            }
        }


    }
}