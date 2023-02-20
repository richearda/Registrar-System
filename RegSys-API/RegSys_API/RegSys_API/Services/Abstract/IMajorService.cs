using ISMS_API.DTOs;
using ISMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services.Abstract
{
    public interface IMajorService
    {
        int AddMajor(Major major);
        int UpdateMajor(Major majorDto);
        int DeleteMajor(int majorID);
        IQueryable<Major> GetMajors();
        Major GetMajor(int majorID);
        Major GetMajorByName(string majorName);
        int ActivateMajor(int ID);
        int DeactivateMajor(int ID);
        bool IsMajorExist(Major majorDto);
    }
}
