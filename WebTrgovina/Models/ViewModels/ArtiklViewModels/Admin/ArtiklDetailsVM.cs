using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTrgovina.Models.ViewModels.ArtiklViewModels.Admin
{
    public class ArtiklDetailsVM
    {
        public ArtiklVM ArtiklVM { get; set; }
        public List<ReviewVM> ReviewsVM { get; set; }
    }
}