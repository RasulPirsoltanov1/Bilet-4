using Bilet_4.Core.Entities;
using Bilet_4.DataAccess.Contetxs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bilet_4.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize]

    public class FeatureController : Controller
	{
		private AppDbContext _context;

        public FeatureController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
		{
			return View(_context.Features);
		}
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Feature feature)
        {
            if(!ModelState.IsValid)
            {
                return View(feature);
            }
            _context.Features.Add(feature);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Features.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            _context.Features.Remove(item);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var item = await _context.Features.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(Feature feature)
        {
            var item = await _context.Features.FindAsync(feature.Id);
            if (item == null)
            {
                return NotFound();
            }
            item.Title = feature.Title;
            item.Description = feature.Description; 
            item.IconName= feature.IconName;
            _context.Features.Update(item);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            var item = await _context.Features.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
    }
}
