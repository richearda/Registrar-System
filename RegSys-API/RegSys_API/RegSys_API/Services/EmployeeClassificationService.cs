﻿using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class EmployeeClassificationService : IEmployeeClassificationService
    {
        private RegSysDbContext _dbContext;

        public EmployeeClassificationService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int ActivateEmployeeClassification(int ID)
        {
            EmployeeClassification toActivate = _dbContext.EmployeeClassifications.Where(c => c.EmployeeClassificationId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddEmployeeClassification(EmployeeClassification employeeClassification)
        {
            _dbContext.EmployeeClassifications.Add(employeeClassification);
            return _dbContext.SaveChanges();
        }

        public int DeactivateEmployeeClassification(int ID)
        {
            EmployeeClassification toDeactivate = _dbContext.EmployeeClassifications.Where(c => c.EmployeeClassificationId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteEmployeeClassification(int ID)
        {
            EmployeeClassification toDelete = _dbContext.EmployeeClassifications.Where(c => c.EmployeeClassificationId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public EmployeeClassification GetEmployeeClassification(int ID)
        {
            return _dbContext.EmployeeClassifications.AsNoTracking().Where(c => c.EmployeeClassificationId == ID).FirstOrDefault();
        }

        public IQueryable<EmployeeClassification> GetEmployeeClassifications()
        {
            return _dbContext.EmployeeClassifications.Where(c => c.IsActive == true);
        }

        public bool IsEmployeeClassificationExist(EmployeeClassification employeeClassification)
        {
            EmployeeClassification checkClassification = _dbContext.EmployeeClassifications.Where(c => c.EmployeeClassificationDescription == employeeClassification.EmployeeClassificationDescription).FirstOrDefault();
            return (checkClassification != null);
        }

        public int UpdateEmployeeClassification(EmployeeClassification employeeClassification)
        {
            _dbContext.Entry(employeeClassification).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }
    }
}