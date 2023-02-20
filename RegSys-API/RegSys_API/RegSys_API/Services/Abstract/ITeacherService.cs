using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ITeacherService
    {
        IQueryable<TeacherDto> GetTeachers();

    }
}
