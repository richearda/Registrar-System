using ISMS_API.DTOs;
using ISMS_API.Handlers;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISMS_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddStudent([FromBody] StudentDto studentDto)
        {
            var result =  _studentService.AddStudent(studentDto);
            return Ok(result);
            
        }



        [HttpPut(Routes.Edit)]
        public IActionResult UpdateStudent([FromBody] StudentDto studentDto)
        {
            var result = _studentService.UpdateStudent(studentDto);
            return Ok(result);
        }

        [HttpPost(Routes.Deactivate)]
        public async Task<IActionResult> DeactivateStudent(int id)
        {
            var result =  _studentService.DeactivateStudent(id);
            return  await Task.FromResult(Ok(result));
        }  

        [HttpDelete(Routes.Delete)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
           var result = _studentService.DeleteStudent(id);
            return await Task.FromResult(Ok(result));
            
        }

        //url: api/Student/getlist   
        [HttpGet(Routes.GetList + "/Enrollees")]
        public IEnumerable<EnrolleeDto> GetEnrollees()
        {
            return _studentService.GetEnrollees();
        }

        [HttpGet(Routes.GetList + "/Enrollments")]
        public IActionResult GetStudentEnrollments([FromQuery] int studentID)
        {
            if (studentID <= 0)
            {
                return BadRequest("Student ID can not be empty");
            }
            var enrollments = _studentService.GetStudentEnrollments(studentID);
            return Ok(enrollments);
        }

        [HttpGet(Routes.Get)]
        public IActionResult GetStudent(int id)
        {
            var result = _studentService.GetStudent(id);
            return Ok(result);
        }
    }
}

