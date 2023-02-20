using AutoMapper;
using AutoMapper.QueryableExtensions;
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
    public class UserService : IUserService
    {
        private RegSysDbContext _dbContext;
        private IPersonUserService _personUserService;
        private IRoleService _roleService;
        private IMapper _mapper;

        public UserService(RegSysDbContext dbContext, IPersonUserService personUserService, IRoleService roleService, IMapper mapper)
        {
            _dbContext = dbContext;
            _personUserService = personUserService;
            _roleService = roleService;
            _mapper = mapper;
        }

        public int ActivateUser(int userId)
        {
            User activateUser = _dbContext.Users.AsNoTracking().Where(u => u.UserId == userId).FirstOrDefault();
            activateUser.IsActive = true;
            _dbContext.Entry(activateUser).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddUser(UserDetailsDto user)
        {
            user.Password = CryptographyHelper.GenerateHash(user.Password);

            var userModel = new User
            {
                Username = user.Username,
                Password = user.Password,
                RoleId = user.RoleId,
                IsActive = user.IsActive,
            };

            _dbContext.Users.Add(userModel);
            _dbContext.SaveChanges();

            var personModel = new Person
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName = user.MiddleName
            };
            _dbContext.People.Add(personModel);
            _dbContext.SaveChanges();
            var personUserModel = new PersonUser
            {
                UserId = userModel.UserId,
                PersonId = personModel.PersonId
            };
            _dbContext.PersonUsers.Add(personUserModel);
            return _dbContext.SaveChanges();
        }

        public int DeactivateUser(int userId)
        {
            User deactivateUser = _dbContext.Users.AsNoTracking().Where(u => u.UserId == userId).FirstOrDefault();
            deactivateUser.IsActive = false;
            _dbContext.Entry(deactivateUser).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteUser(int userId)
        {
            User deleteUser = _dbContext.Users.AsNoTracking().Where(u => u.UserId == userId).FirstOrDefault();
            _dbContext.Entry(deleteUser).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public UserDetailsDto GetUser(int userId)
        {
            return _dbContext.Users.AsNoTracking().Where(u => u.UserId == userId).ProjectTo<UserDetailsDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public List<UserDetailsDto> GetUsers()
        {
            return _dbContext.PersonUsers.ProjectTo<UserDetailsDto>(_mapper.ConfigurationProvider).ToList();
            //var users = _dbContext.Users.Select(u => new UserDetailsDto
            //{
            //    UserId = u.UserId,
            //    Username = u.Username,
            //    Password = u.Password,
            //    Role = u.Role.RoleName,
            //    IsActive = u.IsActive,

            //});
        }

        public bool IsUserExist(User user)
        {
            User userExist = _dbContext.Users.AsNoTracking().Where(u => u.Username == user.Username).FirstOrDefault();
            return (userExist != null);
        }

        public int UpdateUser(UserDetailsDto user)
        {
            user.Password = CryptographyHelper.GenerateHash(user.Password);

            var userModel = new User
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password,
                RoleId = user.RoleId,
                IsActive = user.IsActive,
            };

            _dbContext.Entry(userModel).State = EntityState.Modified;

            var personModel = new Person
            {
                PersonId = user.PersonId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName = user.MiddleName
            };

            _dbContext.Entry(personModel).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public AppUserDto GetUserDetails(string username, string password)
        {
            string passwordHash = CryptographyHelper.GenerateHash(password);
            User userDetails = _dbContext.Users.Where(u => u.Username == username && u.Password == passwordHash).FirstOrDefault();
            Role userRole = _roleService.GetRole(userDetails.RoleId);
            PersonUser userPerson = _personUserService.GetPersonByUserId(userDetails.UserId);

            var appUser = new AppUserDto()
            {
                PersonID = userPerson.PersonId,
                Name = userPerson.Person.FirstName + " " + userPerson.Person.LastName + " " + (userPerson.Person.MiddleName == null ? "" : userPerson.Person.MiddleName),
                Role = userRole.RoleName
            };
            return appUser;
        }
    }
}