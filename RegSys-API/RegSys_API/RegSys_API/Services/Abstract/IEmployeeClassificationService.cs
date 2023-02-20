using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IEmployeeClassificationService
    {
        IQueryable<EmployeeClassification> GetEmployeeClassifications();
        int AddEmployeeClassification(EmployeeClassification EmployeeClassification);
        int UpdateEmployeeClassification(EmployeeClassification EmployeeClassification);
        int ActivateEmployeeClassification(int ID);
        int DeactivateEmployeeClassification(int ID);
        int DeleteEmployeeClassification(int ID);
        bool IsEmployeeClassificationExist(EmployeeClassification EmployeeClassification);
        EmployeeClassification GetEmployeeClassification(int ID);



    }
}
