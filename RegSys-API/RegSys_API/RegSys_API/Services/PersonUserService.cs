using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class PersonUserService : IPersonUserService
    {
        private RegSysDbContext _dbContext;

        public PersonUserService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PersonUser GetPersonByUserId(int id)
        {
            return _dbContext.PersonUsers.Include(pu => pu.Person).Where(pu => pu.UserId == id).FirstOrDefault();
        }
    }
}