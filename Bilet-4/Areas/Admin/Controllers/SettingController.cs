using Bilet_4.DataAccess.Contetxs;
using Bilet_4.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bilet_4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _context.Settings.FindAsync(1));
        }
        //public async Task<IActionResult> Update()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Update(SettingViewModel newSetting)
        //{
        //    if(!ModelState.IsValid) { 
        //        return View(newSetting);
        //    }
        //    var newSetting=
        //    return View();
        //}
    }
}
