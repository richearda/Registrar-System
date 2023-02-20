using Microsoft.AspNetCore.Mvc;
using System;

namespace EnrollmentSystem.Controllers
{
    public class RegistrarAssistantController : Controller
    {
        public IActionResult ManageEnrollment()
        {
            ViewData["Header"] = "Manage Enrollment";
            ViewData["MainHeader"] = "Enrollment List";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Enrollment/ManageEnrollment.cshtml");
        }

        public IActionResult ManageStudents()
        {
            ViewData["Header"] = "Manage Enrollment";
            ViewData["MainHeader"] = "Enrollment List";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Students/ManageStudents.cshtml");
        }

        public IActionResult GenerateMasterList()
        {
            ViewData["Header"] = "Generate Master List";
            ViewData["MainHeader"] = "Subject Master List";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Report/MasterList.cshtml");
        }
    }
}