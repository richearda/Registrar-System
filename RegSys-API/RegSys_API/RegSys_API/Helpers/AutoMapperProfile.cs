using AutoMapper;
using ISMS_API.DTOs;
using ISMS_API.Models;
using System;
using System.Runtime.InteropServices;

namespace ISMS_API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();

            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<CivilStatus, CivilStatusDto>().ReverseMap();
            CreateMap<Citizenship, CitizenshipDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressType, AddressTypeDto>().ReverseMap();
            CreateMap<Barangay, BarangayDto>().ReverseMap();
            CreateMap<CityMunicipality, CityMunicipalityDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();

            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Major, MajorDto>().ReverseMap();
            CreateMap<ISMS_API.Models.Program, ProgramDto>().ReverseMap();
            CreateMap<ProgramMajor, ProgramMajorDto>().ReverseMap();
            CreateMap<Student, EnrolleeDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Person.FirstName + " " + src.Person.LastName + (src.Person.MiddleName == null ? "" : " " + src.Person.MiddleName)))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Program.ProgramCode))
                .ForMember(dest => dest.Major, opt => opt.MapFrom(src => src.Major.MajorCode));
            CreateMap<CourseSchedule, CourseScheduleDto>()
                .ForMember(dest => dest.CourseCode, opt => opt.MapFrom(src => src.Course.CourseCode))
                .ForMember(dest => dest.CourseDescription, opt => opt.MapFrom(src => src.Course.CourseDescription))
                .ForMember(dest => dest.Units, opt => opt.MapFrom(src => src.Course.Units))
                .ForMember(dest => dest.Day, opt => opt.MapFrom(src => src.Day.DayCode))
                .ForMember(dest => dest.TimeStart, opt => opt.MapFrom(src => src.TimeStart))
                .ForMember(dest => dest.MidDayTimeStart, opt => opt.MapFrom(src => src.MidDayIdtimeStartNavigation.MidDayName))
                .ForMember(dest => dest.TimeEnd, opt => opt.MapFrom(src => src.TimeEnd))
                .ForMember(dest => dest.MidDayTimeEnd, opt => opt.MapFrom(src => src.MidDayIdtimeEndNavigation.MidDayName))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Room.RoomCode));
            CreateMap<CourseScheduleDto, CourseSchedule>();

            CreateMap<Enrollment, EnrollmentDto>()
                .ForMember(dest => dest.Term, opt => opt.MapFrom(src => src.Term.TermCode))
                .ForMember(dest => dest.Semester, opt => opt.MapFrom(src => src.Semester.SemesterName));

            CreateMap<EnrollmentDto, Enrollment>();
            CreateMap<EnrollmentCourseSchedule, EnrollmentCourseScheduleDto>().ReverseMap();
            CreateMap<Enrollment, GetStudentEnrollmentsDto>()
                .ForMember(dest => dest.Term, opt => opt.MapFrom(src => src.Term.TermCode))
                .ForMember(dest => dest.Semester, opt => opt.MapFrom(src => src.Semester.SemesterName));
            CreateMap<Term, TermDto>().ReverseMap();
            CreateMap<Semester, SemesterDto>().ReverseMap();
            CreateMap<Teacher, TeacherDto>();
            CreateMap<Fee, FeeDto>()
                .ForMember(dest => dest.FeeTypeDescription, opt => opt.MapFrom(src => src.FeeType.FeeTypeDescription));
            CreateMap<FeeType, FeeTypeDto>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap()
                 .ForMember(dest => dest.FeeTypeId, opt => opt.MapFrom(src => src.FeeType.FeeTypeId));
            CreateMap<Block, BlockDto>().ReverseMap();
            CreateMap<Block, GetBlockDto>()
                .ForMember(dest => dest.Program, opt => opt.MapFrom(src => src.Program.ProgramName))
                .ForMember(dest => dest.Major, opt => opt.MapFrom(src => src.Major.MajorCode))
                .ForMember(dest => dest.Term, opt => opt.MapFrom(src => src.Term.TermCode))
                .ForMember(dest => dest.Semester, opt => opt.MapFrom(src => src.Semester.SemesterName));
            CreateMap<BlockCourseSchedule, BlockCourseScheduleDto>()
                .ForMember(dest => dest.CourseSchedule, opt => opt.MapFrom(src => src.CourseSchedules));
            CreateMap<BlockCourseSchedule, GetBlockCoursesDto>()
                .ForMember(dest => dest.CourseSchedules, opt => opt.MapFrom(src => src.CourseSchedules))
                .ForMember(dest => dest.BlockName, opt => opt.MapFrom(src => src.Blocks.BlockName));
            CreateMap<EnrollmentCourseSchedule, AddEnrollmentCourseSchedulesDto>().ReverseMap();
            //CreateMap<EnrollmentCourseSchedule, EnrollmentBlockDto>();
            CreateMap<Enrollment, GetStudentEnrollmentDetails>()
                .ForMember(dest => dest.Term, opt => opt.MapFrom(src => src.Term.TermCode))
                .ForMember(dest => dest.Semester, opt => opt.MapFrom(src => src.Semester.SemesterName))
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Student.StudentId))
                .ForMember(dest => dest.StudentNo, opt => opt.MapFrom(src => src.Student.StudentNo))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Student.Person.FirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.Student.Person.MiddleName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Student.Person.LastName))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Student.Program.ProgramCode))
                .ForMember(dest => dest.Major, opt => opt.MapFrom(src => src.Student.Major.MajorName))
                .ForMember(dest => dest.YearLevel, opt => opt.MapFrom(src => src.Student.YearLevel))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Student.Person.FirstName + " " + src.Student.Person.LastName + (src.Student.Person.MiddleName == null ? "" : " " + src.Student.Person.MiddleName)));
            //.ForMember(dest => dest.EnrollmentBlocks, opt => opt.MapFrom(src => src.EnrollmentBlocks));
            //CreateMap<EnrollmentCourseSchedule, GetStudentBlockDetails>()
            //    .ForMember(dest => dest.BlockId, opt => opt.MapFrom(src => src.BlockId))
            //    .ForMember(dest => dest.BlockName, opt => opt.MapFrom(src => src.Block.BlockName))
            //    .ForMember(dest => dest.BlockCourses, opt => opt.MapFrom(src => src.Block.BlockCourseSchedules));
            CreateMap<BlockCourseSchedule, BlockCoursesDto>()
                .ForMember(dest => dest.CourseSchedule, opt => opt.MapFrom(src => src.CourseSchedules));
            CreateMap<Payable, StudentPayableDetailsDto>()
                .ForMember(dest => dest.Fee, opt => opt.MapFrom(src => src.Fee.FeeName))
                .ForMember(dest => dest.FeeType, opt => opt.MapFrom(src => src.Fee.FeeType.FeeTypeDescription))
                .ForMember(dest => dest.FeeAmount, opt => opt.MapFrom(src => src.Fee.FeeAmount))
                .ForMember(dest => dest.PayableRef, opt => opt.MapFrom(src => src.PayableRefNo));

            //Map User DTO to User model
            CreateMap<User, UserDto>()
            //.ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserId))
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));
            //.ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId));
            //CreateMap<User, UserDetailsDto>()
            //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
            //.ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
            //.ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
            //.ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.RoleName))
            //.ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId));

            CreateMap<PersonUser, PersonUserDto>().ReverseMap()
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
            .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));
            //.ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person))
            //.ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

            CreateMap<PersonUser, UserDetailsDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User.Password))
                .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Person.LastName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.Person.MiddleName))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.User.RoleId))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.User.Role.RoleName))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.User.IsActive));

            CreateMap<PersonUser, PersonUserDetailsDto>()
                .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Person.LastName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.Person.MiddleName));

            CreateMap<EnrollmentCourseSchedule, GetEnrollmentCourseScheduleDto>()
                .ForMember(dest => dest.CourseSchedules, opt => opt.MapFrom(src => src.CourseSchedule));
            CreateMap<TeacherCourseSchedule, TeacherCourseScheduleDto>()
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.Teacher.TeacherId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Teacher.Person.FirstName + " " + src.Teacher.Person.LastName + (src.Teacher.Person.MiddleName == null ? "" : " " + src.Teacher.Person.MiddleName)));
            CreateMap<EnrollmentCourseSchedule, GetEnrollmentStudentDto>()
                .ForMember(dest => dest.EnrollmentCourseScheduleId, opt => opt.MapFrom(src => src.EnrollmentCourseScheduleId))
                .ForMember(dest => dest.EnrollmentId, opt => opt.MapFrom(src => src.EnrollmentId))
                .ForMember(dest => dest.CourseScheduleId, opt => opt.MapFrom(src => src.CourseScheduleId))
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Enrollment.StudentId))
                .ForMember(dest => dest.StudentNo, opt => opt.MapFrom(src => src.Enrollment.Student.StudentNo))
                .ForMember(dest => dest.EnrollmentCourseScheduleId, opt => opt.MapFrom(src => src.EnrollmentCourseScheduleId))
                .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Enrollment.Student.Person.FirstName + " " + src.Enrollment.Student.Person.LastName + (src.Enrollment.Student.Person.MiddleName == null ? "" : " " + src.Enrollment.Student.Person.MiddleName)))
                .ForMember(dest => dest.YearLevel, opt => opt.MapFrom(src => src.Enrollment.Student.YearLevel))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Enrollment.Student.Program.ProgramCode))
                .ForMember(dest => dest.Major, opt => opt.MapFrom(src => src.Enrollment.Student.Major.MajorCode));
            CreateMap<EnrollmentCourseSchedule, GetStudentSubjectListDto>()
                .ForMember(dest => dest.EnrollmentCourseScheduleId, opt => opt.MapFrom(src => src.EnrollmentCourseScheduleId))
                .ForMember(dest => dest.EnrollmentId, opt => opt.MapFrom(src => src.EnrollmentId))
                .ForMember(dest => dest.CourseScheduleId, opt => opt.MapFrom(src => src.CourseScheduleId))
                .ForMember(dest => dest.CourseCode, opt => opt.MapFrom(src => src.CourseSchedule.Course.CourseCode))
                .ForMember(dest => dest.CourseDescription, opt => opt.MapFrom(src => src.CourseSchedule.Course.CourseDescription))
                .ForMember(dest => dest.Units, opt => opt.MapFrom(src => src.CourseSchedule.Course.Units));
        }
    }
}