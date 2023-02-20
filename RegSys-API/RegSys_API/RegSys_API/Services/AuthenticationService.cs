using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private RegSysDbContext _dbContext;

        public AuthenticationService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AppUserDto AuthenticateUser(UserDto user)
        {
            AppUserDto userDto = new AppUserDto();
            string passwordHash = CryptographyHelper.GenerateHash(user.Password);
            User userAccount = _dbContext.Users.Where(u => u.Username == user.Username && u.Password == passwordHash).FirstOrDefault();
            if (userAccount != null)
            {
                PersonUser personUser = _dbContext.PersonUsers.AsNoTracking().Where(u => u.UserId == userAccount.UserId)
                    .Include(u => u.User.Role).Include(u => u.Person).FirstOrDefault();

                userDto.PersonID = personUser.PersonId;
                userDto.Name = personUser.Person.FirstName + " " + personUser.Person.LastName;
                userDto.Role = personUser.User.Role.RoleName;
            }
            return userDto;
        }
    }
}