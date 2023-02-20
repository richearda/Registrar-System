using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;

namespace ISMS_API.Services.Abstract
{
    public interface IPersonService
    {
        int AddPerson(PersonDto personDto);
        int UpdatePerson(PersonDto personDto);
        int DeletePerson(int personID);
        PersonDto GetPerson(int personID);
        IEnumerable<PersonDto> GetPeople();
        int ActivatePerson(int ID);
        int DeactivatePerson(int ID);
        bool IsPersonExist(Person person);
    }
}
