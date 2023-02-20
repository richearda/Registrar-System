using Microsoft.AspNetCore.Mvc;

namespace EnrollmentSystem.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult GenerateStudyLoad()
        {
            return View("StudyLoad");
        }

        public IActionResult GenerateMasterList()
        {
            return View("MasterList");
        }
    }
}