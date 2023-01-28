using Bilet_4.DataAccess.Contetxs;
using Microsoft.AspNetCore.Mvc;

namespace Bilet_4.Controllers
{
    public class HomeController : Controller
    {
		private AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View(_context.Features);
        }
    }
}
