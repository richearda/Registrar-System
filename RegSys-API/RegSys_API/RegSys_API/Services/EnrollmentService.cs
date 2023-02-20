using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private RegSysDbContext _dbContext;
        private IStudentService _studentService;

        private IMapper _mapper;

        public EnrollmentService(RegSysDbContext dbContext, IMapper mapper, IStudentService studentService)
        {
            _dbContext = dbContext;
            _studentService = studentService;
            _mapper = mapper;
        }

        public int ActivateEnrollment(int enrollmentId)
        {
            Enrollment activateEnrollment = _dbContext.Enrollments.Where(b => b.EnrollmentId == enrollmentId).FirstOrDefault();
            activateEnrollment.IsActive = true;
            _dbContext.Entry(activateEnrollment).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddEnrollment(EnrollmentDto enrollmentDto)
        {
            var student = _dbContext.Students.Where(s => s.StudentId == enrollmentDto.StudentId).FirstOrDefault();
            var term = _dbContext.Terms.Where(t => t.TermId == enrollmentDto.TermId).FirstOrDefault();
            var semester = _dbContext.Semesters.Where(s => s.SemesterId == enrollmentDto.SemesterId).FirstOrDefault();

            var enrollment = new Enrollment
            {
                EnrollmentNo = enrollmentDto.EnrollmentNo,
                Student = student,
                Term = term,
                Semester = semester,
                EnrollmentDate = System.DateTime.Today,
                IsActive = enrollmentDto.IsActive
            };

            _dbContext.Enrollments.Add(enrollment);
            _dbContext.SaveChanges();
            return enrollment.EnrollmentId;

            //var enrollmentSchedules = new EnrollmentCourseScheduleDto
            //{
            //    EnrollmentId = enrollment.EnrollmentId,
            //    CourseScheduleIds = schedIds
            //};

            //var result = _enrollmentCourseScheduleService.AddEnrollmentCourseSchedules(enrollmentSchedules);
            //return result;
        }

        public int DeactivateEnrollment(int enrollmentId)
        {
            Enrollment deactivateEnrollment = _dbContext.Enrollments.Where(b => b.EnrollmentId == enrollmentId).FirstOrDefault();
            deactivateEnrollment.IsActive = false;
            _dbContext.Entry(deactivateEnrollment).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteEnrollment(int id)
        {
            Enrollment deleteEnrollment = _dbContext.Enrollments.Where(b => b.EnrollmentId == id).FirstOrDefault();
            _dbContext.Entry(deleteEnrollment).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Enrollment GetEnrollment(int enrollmentId)
        {
            return _dbContext.Enrollments.AsNoTracking().Where(b => b.EnrollmentId == enrollmentId).FirstOrDefault();
        }

        public Enrollment GetCurrentEnrollment(int studentId, int termId, int semesterId)
        {
            var currentEnrollment = _dbContext.Enrollments.Where(e => e.StudentId == studentId && e.TermId == termId && e.SemesterId == semesterId).FirstOrDefault();
            return currentEnrollment;
        }

        public IQueryable<Enrollment> GetEnrollments()
        {
            return _dbContext.Enrollments.Where(b => b.IsActive == true);
        }

        public bool IsEnrollmentExist(Enrollment enrollment)
        {
            bool isTrue = false;
            if (_dbContext.Enrollments.Any(b => b.EnrollmentId == enrollment.EnrollmentId))
            { return isTrue = true; }
            return isTrue;
        }

        public int UpdateEnrollment(Enrollment enrollment)
        {
            _dbContext.Entry(enrollment).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        //public List<EnrollmentCoursesDto> GetEnrollmentCourses(int enrollmentId)
        //{
        //    return _dbContext.EnrollmentCourseSchedules.Include(e => e.CourseSchedule).
        //        Where(e => e.EnrollmentId == enrollmentId).ProjectTo<EnrollmentCoursesDto>(_mapper.ConfigurationProvider).ToList();
        //}

        public IEnumerable<CourseScheduleDto> GetNotEnrolledCourseSchedules(int[] enrolledCourseIds)
        {
            var unenrolledCourses = _dbContext.CourseSchedules.Where(c => c.CourseScheduleId != 0 && (!enrolledCourseIds.Contains((int)c.CourseScheduleId))).ProjectTo<CourseScheduleDto>(_mapper.ConfigurationProvider);
            return unenrolledCourses;
            //var courses = _dbContext.Enrollments.Include(e => e.CourseSchedules.Contains(enrollmentSchedules)).ToList();
        }

        public List<GetStudentEnrollmentDetails> GetEnrollmentDto(int programId, int majorId, int termId, int semesterId)
        {
            var enrollments = _dbContext.Enrollments.Where(e => e.TermId == termId && e.SemesterId == semesterId && e.Student.ProgramId == programId && e.Student.MajorId == majorId).ProjectTo<GetStudentEnrollmentDetails>(_mapper.ConfigurationProvider).ToList();
            return enrollments;
        }
    }
}