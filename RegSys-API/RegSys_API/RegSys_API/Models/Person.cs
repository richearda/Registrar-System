using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ISMS_API.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string NameExtension { get; set; }
        public int? GenderId { get; set; }
        public int? CivilStatusId { get; set; }
        public int? Age { get; set; }
        public string Birthplace { get; set; }
        public DateTime? Birthdate { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public int? BloodTypeId { get; set; }
        public int? CitizenshipId { get; set; }
        public int? DualCitizenshipAcquisitionId { get; set; }
        public int? CountryId { get; set; }
        public int? AddressId { get; set; }

        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public bool? IsActive { get; set; }
        public string PictureLink { get; set; }
        public virtual Address Address { get; set; }
        public virtual BloodType BloodType { get; set; }
        public virtual Citizenship Citizenship { get; set; }
        public virtual CivilStatus CivilStatus { get; set; }
        public virtual Country Country { get; set; }
        public virtual DualCitizenshipAcquisition DualCitizenshipAcquisition { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EvaluationResponse> EvaluationResponseEvaluatedByPeople { get; set; }
        public virtual ICollection<EvaluationResponse> EvaluationResponseEvaluationForPeople { get; set; }
        public virtual ICollection<PersonChild> PersonChildren { get; set; }
        public virtual ICollection<PersonConfirmationQuestion> PersonConfirmationQuestions { get; set; }
        public virtual ICollection<PersonEducationalBackground> PersonEducationalBackgrounds { get; set; }
        public virtual ICollection<PersonOathDeclaration> PersonOathDeclarations { get; set; }
        public virtual ICollection<PersonOrganizationMembershipInformation> PersonOrganizationMembershipInformations { get; set; }
        public virtual ICollection<PersonParentsFamilyBackground> PersonParentsFamilyBackgrounds { get; set; }
        public virtual ICollection<PersonRecognitionInformation> PersonRecognitionInformations { get; set; }
        public virtual ICollection<PersonReference> PersonReferences { get; set; }
        public virtual ICollection<PersonServiceEligibility> PersonServiceEligibilities { get; set; }
        public virtual ICollection<PersonSkillsInformation> PersonSkillsInformations { get; set; }
        public virtual ICollection<PersonSpouseFamilyBackground> PersonSpouseFamilyBackgrounds { get; set; }
        public virtual ICollection<PersonTrainingProgram> PersonTrainingPrograms { get; set; }
        public virtual ICollection<PersonUser> PersonUsers { get; set; }
        public virtual ICollection<PersonVoluntaryWork> PersonVoluntaryWorks { get; set; }
        public virtual ICollection<PersonWorkExperience> PersonWorkExperiences { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}