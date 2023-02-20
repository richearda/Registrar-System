using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IStudentService
    {

        int AddStudent(StudentDto studentDto);
        int UpdateStudent(StudentDto studentDto);
        int DeleteStudent(int studentID);
        IQueryable<Student> GetStudents();
        IEnumerable<EnrolleeDto> GetEnrollees();
        StudentDto GetStudent(int Id);
        int ActivateStudent(int ID);
        int DeactivateStudent(int ID);
        bool IsStudentExist(StudentDto studentDto);
        List<GetStudentEnrollmentsDto> GetStudentEnrollments(int studentID);


    }
}
