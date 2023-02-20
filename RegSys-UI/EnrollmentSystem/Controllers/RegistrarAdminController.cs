using Microsoft.AspNetCore.Mvc;
using System;

namespace EnrollmentSystem.Controllers
{
    public class RegistrarAdminController : Controller
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

        public IActionResult GenerateStudyLoad()
        {
            ViewData["Header"] = "Generate";
            ViewData["MainHeader"] = "Study Load";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Report/StudyLoad.cshtml");
        }

        public IActionResult GenerateMasterList()
        {
            ViewData["Header"] = "Generate Master List";
            ViewData["MainHeader"] = "Subject Master List";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Report/MasterList.cshtml");
        }

        public IActionResult ManageBlock()
        {
            ViewData["Header"] = "Manage Block";
            ViewData["MainHeader"] = "Manage";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Block/ManageBlock.cshtml");
        }

        public IActionResult ManageBlockSubject()
        {
            ViewData["Header"] = "Manage Subject";
            ViewData["MainHeader"] = "Manage";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/Block/ManageBlockSubject.cshtml");
        }

        public IActionResult ManageUser()
        {
            ViewData["Header"] = "Manage";
            ViewData["MainHeader"] = "Users";
            ViewData["Role"] = Convert.ToString(RouteData.Values["Controller"]);
            return View("~/Views/User/ManageUser.cshtml");
        }
    }
}