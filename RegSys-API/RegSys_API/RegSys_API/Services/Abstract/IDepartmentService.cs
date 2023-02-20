using ISMS_API.DTOs;
using System.Collections.Generic;

namespace ISMS_API.Services.Abstract
{
    public interface IDepartmentService
    {
        List<MajorDto> GetDepartmentMajors(int departmentId);
    }
}