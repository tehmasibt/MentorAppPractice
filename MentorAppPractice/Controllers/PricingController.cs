using MentorAppPractice.Data;
using MentorAppPractice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorAppPractice.Controllers
{
    public class PricingController : Controller
    {
        private readonly MentorAppDbContext _context;

        public PricingController(MentorAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PricingVM pricingVM = new PricingVM();
            pricingVM.Pricings=_context.Pricings
                .Include(p=>p.PricingServices)
                .ThenInclude(ps=>ps.Service)
                .ToList();
            pricingVM.Services = _context.Services.ToList();
            return View(pricingVM);
        }
    }
}
