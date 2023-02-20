using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private RegSysDbContext _dbContext;

        public EmployeeService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return _dbContext.SaveChanges();
        }

        public int DeleteEmployee(int employeeID)
        {
            Employee deleteEmployee = _dbContext.Employees.Where(e => e.EmployeeId == employeeID).FirstOrDefault();
            _dbContext.Entry(deleteEmployee).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Employee GetEmployee(int employeeID)
        {
            return _dbContext.Employees.Where(e => e.EmployeeId == employeeID).FirstOrDefault();
        }

        public IQueryable<Employee> GetEmployees()
        {
            return _dbContext.Employees;
        }

        public bool IsEmployeeExist(Employee employee)
        {
            Employee employeeId = _dbContext.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
            return (employeeId != null);
        }

        public int UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }
    }
}