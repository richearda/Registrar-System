using EnrollmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnrollmentSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult EnrollStudent(Student student)
        {
            ViewData["Title"] = "Enroll Student";
            return PartialView(student);
        }

        public IActionResult ManageEnrollment()
        {
            ViewData["Title"] = "Manage Enrollment";
            return View();
        }

        public IActionResult EnrollmentInfo(Student student)
        {
            return PartialView(student);
        }

        //public IActionResult EnrollStudent(string fullName, string studentId, string studentNumber, string course, string major, string yearLevel)
        //{
        //    ViewData["Title"] = "Enroll Student";
        //    return View();
        //}
    }
}
