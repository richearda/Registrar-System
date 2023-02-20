using Microsoft.AspNetCore.Mvc;

namespace EnrollmentSystem.Controllers
{
    public class BlockController : Controller
    {
        public IActionResult ManageBlock()
        {
            ViewData["Title"] = "Manage Block";
            return View();
        }

        public IActionResult ManageBlockSubject()
        {
            ViewData["Title"] = "Manage Block Subject";
            return View();
        }
    }
}