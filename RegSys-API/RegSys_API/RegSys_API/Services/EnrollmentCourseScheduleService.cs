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
    public class EnrollmentBlockService : IEnrollmentCourseScheduleService
    {
        private readonly RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public EnrollmentBlockService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int AddEnrollmentCourseSchedule(AddEnrollmentCourseSchedulesDto enrollmentCourseSchedDto)
        {
            var enrollment = _dbContext.Enrollments.Where(e => e.EnrollmentId == enrollmentCourseSchedDto.EnrollmentId).FirstOrDefault();
            var scheds = _dbContext.CourseSchedules.Where(c => enrollmentCourseSchedDto.CourseScheduleIds.Contains(c.CourseScheduleId));

            foreach (var sched in scheds)
            {
                var enrollmentSchedules = new EnrollmentCourseSchedule
                {
                    EnrollmentId = enrollment.EnrollmentId,
                    CourseScheduleId = sched.CourseScheduleId,
                };
                _dbContext.EnrollmentCourseSchedules.Add(enrollmentSchedules);
            }
            return _dbContext.SaveChanges();
            //var dtoToModel = _mapper.Map<EnrollmentBlock>(enrollmentBlockDto);
        }

        public int DeleteEnrollmentCourseSchedule(int ID)
        {
            EnrollmentCourseSchedule toDelete = _dbContext.EnrollmentCourseSchedules.Where(e => e.EnrollmentCourseScheduleId == ID).FirstOrDefault();
            Enrollment deleteEnrollment = _dbContext.Enrollments.Where(e => e.EnrollmentId == toDelete.EnrollmentId).FirstOrDefault();
            _dbContext.Entry(deleteEnrollment).State = EntityState.Deleted;
            if (toDelete != null)
            {
                _dbContext.Entry(toDelete).State = EntityState.Deleted;
            }
            return _dbContext.SaveChanges();
        }
            

        public List<GetEnrollmentCourseScheduleDto> GetEnrollmentCourseSchedule(int ID)
        {
            return _dbContext.EnrollmentCourseSchedules.Where(e => e.EnrollmentId == ID).ProjectTo<GetEnrollmentCourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<EnrollmentCourseScheduleDto> GetEnrollmentCourseScheduleByStudentId(int ID)
        {
            return _dbContext.EnrollmentCourseSchedules.Where(e => e.Enrollment.StudentId == ID).ProjectTo<EnrollmentCourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<EnrollmentCourseSchedule> GetEnrollmentCourseSchedules()
        {
            return _dbContext.EnrollmentCourseSchedules.ToList();
        }

        public int UpdateEnrollmentCourseSchedule(EnrollmentCourseSchedule enrollmentBlock)
        {
            _dbContext.Entry(enrollmentBlock).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public List<GetEnrollmentStudentDto> GetStudentInSubject(int termId, int semesterId, int courseSchedId)
        {
            return _dbContext.EnrollmentCourseSchedules.Where(e => e.Enrollment.TermId == termId && e.Enrollment.SemesterId == semesterId && e.CourseScheduleId == courseSchedId).ProjectTo<GetEnrollmentStudentDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<GetStudentSubjectListDto> GetStudentSubjectList(int termId, int semesterId, int studentId)
        {
            return _dbContext.EnrollmentCourseSchedules.Where(e => e.Enrollment.TermId == termId && e.Enrollment.SemesterId == semesterId && e.Enrollment.StudentId == studentId).ProjectTo<GetStudentSubjectListDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}