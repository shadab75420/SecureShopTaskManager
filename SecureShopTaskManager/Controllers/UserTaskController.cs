using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureShopTaskManager.Data;
using SecureShopTaskManager.Models;

namespace SecureShopTaskManager.Controllers
{
    [Authorize]
    public class UserTaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserTaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.UserTasks.ToList());
        }

        [Authorize(Policy = "CanEditTaskPolicy")]
        public IActionResult Edit(int id)
        {
            var task = _context.UserTasks.Find(id);

            return View(task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "CanEditTaskPolicy")]
        public IActionResult Edit(UserTask task)
        {
            if (ModelState.IsValid)
            {
                _context.UserTasks.Update(task);

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }
    }
}