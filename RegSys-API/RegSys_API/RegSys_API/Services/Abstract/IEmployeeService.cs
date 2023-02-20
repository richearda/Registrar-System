using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IEmployeeService
    {

        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int employeeID);
        IQueryable<Employee> GetEmployees();
        Employee GetEmployee(int employeeID);
        bool IsEmployeeExist(Employee employee);


    }
}
