using ISMS_API.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ISMS_API.Data
{
    public partial class RegSysDbContext : DbContext
    {
        public RegSysDbContext()
        {
        }

        public RegSysDbContext(DbContextOptions<RegSysDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public virtual DbSet<Barangay> Barangays { get; set; }
        public virtual DbSet<BloodType> BloodTypes { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<BlockCourseSchedule> BlockCourseSchedules { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<CityMunicipality> CityMunicipalities { get; set; }
        public virtual DbSet<CivilServiceForm> CivilServiceForms { get; set; }
        public virtual DbSet<CivilStatus> CivilStatuses { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<CollegeDepartment> CollegeDepartments { get; set; }
        public virtual DbSet<ConfirmationQuestion> ConfirmationQuestions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<Curriculum> Curricula { get; set; }
        public virtual DbSet<CurriculumCourse> CurriculumCourses { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Dean> Deans { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DesignationStatus> DesignationStatuses { get; set; }
        public virtual DbSet<DualCitizenshipAcquisition> DualCitizenshipAcquisitions { get; set; }
        public virtual DbSet<EducationLevel> EducationLevels { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeClassification> EmployeeClassifications { get; set; }
        public virtual DbSet<EmployeeLeaveCredit> EmployeeLeaveCredits { get; set; }
        public virtual DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<EnrollmentCourseSchedule> EnrollmentCourseSchedules { get; set; }
        public virtual DbSet<EvaluationCriterion> EvaluationCriteria { get; set; }
        public virtual DbSet<EvaluationItem> EvaluationItems { get; set; }
        public virtual DbSet<EvaluationRemark> EvaluationRemarks { get; set; }
        public virtual DbSet<EvaluationResponse> EvaluationResponses { get; set; }
        public virtual DbSet<EvaluationResponseDetail> EvaluationResponseDetails { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<FeeType> FeeTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GovernmentIssuedIdentification> GovernmentIssuedIdentifications { get; set; }
        public virtual DbSet<GradeRemark> GradeRemarks { get; set; }
        public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }
        public virtual DbSet<LeaveApplicationStatus> LeaveApplicationStatuses { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MidDay> MidDays { get; set; }
        public virtual DbSet<Payable> Payables { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<PayableTransaction> PayableTransactions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonChild> PersonChildren { get; set; }
        public virtual DbSet<PersonConfirmationQuestion> PersonConfirmationQuestions { get; set; }
        public virtual DbSet<PersonEducationalBackground> PersonEducationalBackgrounds { get; set; }
        public virtual DbSet<PersonOathDeclaration> PersonOathDeclarations { get; set; }
        public virtual DbSet<PersonOrganizationMembershipInformation> PersonOrganizationMembershipInformations { get; set; }
        public virtual DbSet<PersonParentsFamilyBackground> PersonParentsFamilyBackgrounds { get; set; }
        public virtual DbSet<PersonRecognitionInformation> PersonRecognitionInformations { get; set; }
        public virtual DbSet<PersonReference> PersonReferences { get; set; }
        public virtual DbSet<PersonServiceEligibility> PersonServiceEligibilities { get; set; }
        public virtual DbSet<PersonSkillsInformation> PersonSkillsInformations { get; set; }
        public virtual DbSet<PersonSpouseFamilyBackground> PersonSpouseFamilyBackgrounds { get; set; }
        public virtual DbSet<PersonTrainingProgram> PersonTrainingPrograms { get; set; }
        public virtual DbSet<PersonUser> PersonUsers { get; set; }
        public virtual DbSet<PersonVoluntaryWork> PersonVoluntaryWorks { get; set; }
        public virtual DbSet<PersonWorkExperience> PersonWorkExperiences { get; set; }
        public virtual DbSet<ISMS_API.Models.Program> Programs { get; set; }
        public virtual DbSet<ProgramMajor> ProgramMajors { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleMenu> RoleMenus { get; set; }
        public virtual DbSet<RoleProject> RoleProjects { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<ShsSubject> ShsSubjects { get; set; }
        public virtual DbSet<ShsSubjectSchedule> ShsSubjectSchedules { get; set; }
        public virtual DbSet<Strand> Strands { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourseSchedule> StudentCourseSchedules { get; set; }
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }
        public virtual DbSet<StudentType> StudentTypes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherCourseSchedule> TeacherCourseSchedules { get; set; }
        public virtual DbSet<TeacherShsSubjectSchedule> TeacherShsSubjectSchedules { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<TrainingProgramType> TrainingProgramTypes { get; set; }
        public virtual DbSet<TuitionFeeRate> TuitionFeeRates { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public object CivilStatus { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ISMSDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.BarangayId).HasColumnName("BarangayID");

                entity.Property(e => e.CityMunicipalityId).HasColumnName("CityMunicipalityID");

                entity.Property(e => e.HouseBlkLotNo).HasMaxLength(30);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Street).HasMaxLength(30);

                entity.Property(e => e.SubdivisionVillage).HasMaxLength(30);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK__Address__Address__078C1F06");

                entity.HasOne(d => d.Barangay)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.BarangayId)
                    .HasConstraintName("FK_Address_Barangay");

                entity.HasOne(d => d.CityMunicipality)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityMunicipalityId)
                    .HasConstraintName("FK_Address_CityMunicipality");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Address_Province");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AddressTypeName).HasMaxLength(25);
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.ToTable("AppointmentStatus");

                entity.Property(e => e.AppointmentStatusId).HasColumnName("AppointmentStatusID");

                entity.Property(e => e.AppointmentStatusDescription).HasMaxLength(15);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Barangay>(entity =>
            {
                entity.ToTable("Barangay");

                entity.Property(e => e.BarangayId).HasColumnName("BarangayID");

                entity.Property(e => e.BarangayName).HasMaxLength(50);
                entity.Property(e => e.CityMunicipalityId).HasColumnName("CityMunicipalityID");
            });

            modelBuilder.Entity<BloodType>(entity =>
            {
                entity.ToTable("BloodType");

                entity.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

                entity.Property(e => e.BloodTypeClassification).HasMaxLength(5);
            });

            modelBuilder.Entity<Block>(entity =>
            {
                entity.ToTable("Block");

                entity.Property(e => e.BlockId).HasColumnName("BlockID");
                entity.Property(e => e.BlockName).HasColumnName("BlockName");
                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
                entity.Property(e => e.MajorId).HasColumnName("MajorID");
                entity.Property(e => e.TermId).HasColumnName("TermID");
                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");
            });
            modelBuilder.Entity<BlockCourseSchedule>(entity =>
            {
                entity.ToTable("BlockCourseSchedule");

                entity.Property(e => e.BlockCourseScheduleId).HasColumnName("BlockCourseScheduleID");
                entity.Property(e => e.BlockId).HasColumnName("BlockID");
                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");
            });

            modelBuilder.Entity<Citizenship>(entity =>
            {
                entity.ToTable("Citizenship");

                entity.Property(e => e.CitizenshipId).HasColumnName("CitizenshipID");

                entity.Property(e => e.CitizenshipStatus).HasMaxLength(20);
            });

            modelBuilder.Entity<CityMunicipality>(entity =>
            {
                entity.ToTable("CityMunicipality");

                entity.Property(e => e.CityMunicipalityId).HasColumnName("CityMunicipalityID");

                entity.Property(e => e.CityMunicipalityName).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<CivilServiceForm>(entity =>
            {
                entity.ToTable("CivilServiceForm");

                entity.Property(e => e.CivilServiceFormId).HasColumnName("CivilServiceFormID");

                entity.Property(e => e.FormCode).HasMaxLength(10);

                entity.Property(e => e.FormName).HasMaxLength(50);
            });

            modelBuilder.Entity<CivilStatus>(entity =>
            {
                entity.ToTable("CivilStatus");

                entity.Property(e => e.CivilStatusId).HasColumnName("CivilStatusID");

                entity.Property(e => e.CivilStatusCode).HasMaxLength(5);

                entity.Property(e => e.CivilStatusType).HasMaxLength(20);
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.ToTable("College");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.CollegeCode).HasMaxLength(10);

                entity.Property(e => e.CollegeName).HasMaxLength(50);
            });

            modelBuilder.Entity<CollegeDepartment>(entity =>
            {
                entity.ToTable("CollegeDepartment");

                entity.Property(e => e.CollegeDepartmentId).HasColumnName("CollegeDepartmentID");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.CollegeDepartments)
                    .HasForeignKey(d => d.CollegeId)
                    .HasConstraintName("FK_CollegeDepartment_College");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.CollegeDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_CollegeDepartment_Department");
            });

            modelBuilder.Entity<ConfirmationQuestion>(entity =>
            {
                entity.ToTable("ConfirmationQuestion");

                entity.Property(e => e.ConfirmationQuestionId).HasColumnName("ConfirmationQuestionID");

                entity.Property(e => e.ParentQuestionId).HasColumnName("ParentQuestionID");

                entity.Property(e => e.QuestionDetails).HasMaxLength(250);

                entity.HasOne(d => d.ParentQuestion)
                    .WithMany(p => p.InverseParentQuestion)
                    .HasForeignKey(d => d.ParentQuestionId)
                    .HasConstraintName("FK_ConfirmationQuestion_ParentQuestion");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CountryID");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseCode).HasMaxLength(15);

                entity.Property(e => e.CourseDescription).HasMaxLength(50);

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_Course_CourseType");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Course__Departme__5C37ACAD");
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.ToTable("CourseSchedule");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Edpcode)
                    .HasMaxLength(15)
                    .HasColumnName("EDPCode");

                entity.Property(e => e.MidDayIdtimeEnd).HasColumnName("MidDayIDTimeEnd");

                entity.Property(e => e.MidDayIdtimeStart).HasColumnName("MidDayIDTimeStart");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.TimeEnd).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart).HasColumnType("time(0)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Schedule_Course");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_Schedule_Day");

                entity.HasOne(d => d.MidDayIdtimeEndNavigation)
                    .WithMany(p => p.CourseScheduleMidDayIdtimeEndNavigations)
                    .HasForeignKey(d => d.MidDayIdtimeEnd)
                    .HasConstraintName("FK_Schedule_MidDayTimeEnd");

                entity.HasOne(d => d.MidDayIdtimeStartNavigation)
                    .WithMany(p => p.CourseScheduleMidDayIdtimeStartNavigations)
                    .HasForeignKey(d => d.MidDayIdtimeStart)
                    .HasConstraintName("FK_Schedule_MidDayTimeStart");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Schedule_Room");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_Schedule_Semester");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Schedule_Term");
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.ToTable("CourseType");

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.CourseTypeDescription).HasMaxLength(50);

                entity.Property(e => e.CourseTypeName).HasMaxLength(10);
            });

            modelBuilder.Entity<Curriculum>(entity =>
            {
                entity.ToTable("Curriculum");

                entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

                entity.Property(e => e.Cmo)
                    .HasMaxLength(50)
                    .HasColumnName("CMO");

                entity.Property(e => e.CurriculumName).HasMaxLength(50);

                entity.Property(e => e.Effectivity).HasColumnType("date");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_Curriculum_Major");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Curriculum_Program");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Curriculum_Term");
            });

            modelBuilder.Entity<CurriculumCourse>(entity =>
            {
                entity.ToTable("CurriculumCourse");

                entity.Property(e => e.CurriculumCourseId).HasColumnName("CurriculumCourseID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CurriculumCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_CurriculumCourse_Course");

                entity.HasOne(d => d.Curriculum)
                    .WithMany(p => p.CurriculumCourses)
                    .HasForeignKey(d => d.CurriculumId)
                    .HasConstraintName("FK_CurriculumCourse_Curriculum");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.CurriculumCourses)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_CurriculumCourse_Semester");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Day");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayCode).HasMaxLength(10);

                entity.Property(e => e.DayName).HasMaxLength(30);
            });

            modelBuilder.Entity<Dean>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dean");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.DeanId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DeanID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.College)
                    .WithMany()
                    .HasForeignKey(d => d.CollegeId)
                    .HasConstraintName("FK__Dean__CollegeID__5B438874");

                entity.HasOne(d => d.Person)
                    .WithMany()
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Dean__PersonID__5A4F643B");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentCode).HasMaxLength(10);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<DesignationStatus>(entity =>
            {
                entity.ToTable("DesignationStatus");

                entity.Property(e => e.DesignationStatusId).HasColumnName("DesignationStatusID");

                entity.Property(e => e.DesignationStatusDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<DualCitizenshipAcquisition>(entity =>
            {
                entity.ToTable("DualCitizenshipAcquisition");

                entity.Property(e => e.DualCitizenshipAcquisitionId).HasColumnName("DualCitizenshipAcquisitionID");

                entity.Property(e => e.DualCitizenshipAcquisitionType).HasMaxLength(20);
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.ToTable("EducationLevel");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.LevelName).HasMaxLength(30);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Designation).HasMaxLength(30);

                entity.Property(e => e.DesignationStatusId).HasColumnName("DesignationStatusID");

                entity.Property(e => e.EmployeeClassificationId).HasColumnName("EmployeeClassificationID");

                entity.Property(e => e.EmployeeNo).HasMaxLength(15);

                entity.Property(e => e.Gsisidno)
                    .HasMaxLength(20)
                    .HasColumnName("GSISIDNo");

                entity.Property(e => e.Hdmfidno)
                    .HasMaxLength(20)
                    .HasColumnName("HDMFIDNo");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PhilHealthNo).HasMaxLength(20);

                entity.Property(e => e.ResolutionNo).HasMaxLength(15);

                entity.Property(e => e.Sssidno)
                    .HasMaxLength(20)
                    .HasColumnName("SSSIDNo");

                entity.Property(e => e.Tinidno)
                    .HasMaxLength(20)
                    .HasColumnName("TINIDNo");

                entity.HasOne(d => d.DesignationStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DesignationStatusId)
                    .HasConstraintName("FK_Employee_DesignationStatus");

                entity.HasOne(d => d.EmployeeClassification)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeClassificationId)
                    .HasConstraintName("FK_Employee_EmployeeClassification");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Employee_Person");
            });

            modelBuilder.Entity<EmployeeClassification>(entity =>
            {
                entity.ToTable("EmployeeClassification");

                entity.Property(e => e.EmployeeClassificationId).HasColumnName("EmployeeClassificationID");

                entity.Property(e => e.EmployeeClassificationDescription).HasMaxLength(30);
            });

            modelBuilder.Entity<EmployeeLeaveCredit>(entity =>
            {
                entity.HasKey(e => e.LeaveCreditsId)
                    .HasName("PK_LeaveCreditsID");

                entity.Property(e => e.LeaveCreditsId).HasColumnName("LeaveCreditsID");

                entity.Property(e => e.DateAsOf).HasColumnType("datetime");

                entity.Property(e => e.EarnedLeaveCredits).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TotalCredits).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.UnusedLeaveCredits).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.UsedLeaveCredits).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeLeaveCredits)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeL__Emplo__603D47BB");
            });

            modelBuilder.Entity<EmployeeSchedule>(entity =>
            {
                entity.ToTable("EmployeeSchedule");

                entity.Property(e => e.EmployeeScheduleId).HasColumnName("EmployeeScheduleID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MidDayIdtimeEnd).HasColumnName("MidDayIDTimeEnd");

                entity.Property(e => e.MidDayIdtimeStart).HasColumnName("MidDayIDTimeStart");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeS__Emplo__5D60DB10");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.ToTable("Enrollment");
                entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
                entity.Property(e => e.EnrollmentNo).HasColumnName("EnrollmentNo");
                entity.Property(e => e.EnrollmentDate).HasColumnName("EnrollmentDate");
                entity.Property(e => e.IsActive).HasColumnName("IsActive");

                entity.HasOne(d => d.Student)
                .WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentEnrollment");

                entity.HasOne(d => d.Term)
                .WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermEnrollment");

                entity.HasOne(d => d.Semester)
               .WithMany(p => p.Enrollments)
               .HasForeignKey(d => d.SemesterId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_SemesterEnrollment");

                entity.HasOne(d => d.Semester)
               .WithMany(p => p.Enrollments)
               .HasForeignKey(d => d.SemesterId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_SemesterEnrollment");
            });

            modelBuilder.Entity<EnrollmentCourseSchedule>(entity =>
            {
                entity.ToTable("EnrollmentCourseSchedule");

                entity.Property(e => e.EnrollmentCourseScheduleId).HasColumnName("EnrollmentCourseScheduleID");

                entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.EnrollmentCourseSchedules)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("FK_EnrollmentCourseSchedule_Enrollment")
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CourseSchedule)
                    .WithMany(p => p.EnrollmentCourseSchedules)
                    .HasForeignKey(d => d.CourseScheduleId)
                    .HasConstraintName("FK_EnrollmentCourseSchedule_CourseSchedule");
            });

            modelBuilder.Entity<EvaluationCriterion>(entity =>
            {
                entity.HasKey(e => e.EvaluationCriteriaId);

                entity.Property(e => e.EvaluationCriteriaId).HasColumnName("EvaluationCriteriaID");

                entity.Property(e => e.EvaluationCriteriaDescription)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EvaluationItem>(entity =>
            {
                entity.ToTable("EvaluationItem");

                entity.Property(e => e.EvaluationItemId).HasColumnName("EvaluationItemID");

                entity.Property(e => e.EvaluationCriteriaId).HasColumnName("EvaluationCriteriaID");

                entity.Property(e => e.EvaluationItemDetails).HasMaxLength(200);

                entity.Property(e => e.EvaluationItemRemarksId).HasColumnName("EvaluationItemRemarksID");

                entity.HasOne(d => d.EvaluationCriteria)
                    .WithMany(p => p.EvaluationItems)
                    .HasForeignKey(d => d.EvaluationCriteriaId)
                    .HasConstraintName("FK_EvaluationCriteriaItem_EvaluationCriteria");

                entity.HasOne(d => d.EvaluationItemRemarks)
                    .WithMany(p => p.EvaluationItems)
                    .HasForeignKey(d => d.EvaluationItemRemarksId)
                    .HasConstraintName("FK__Evaluatio__Evalu__7908F585");
            });

            modelBuilder.Entity<EvaluationRemark>(entity =>
            {
                entity.HasKey(e => e.EvaluationItemRemarksId);

                entity.Property(e => e.EvaluationItemRemarksId).HasColumnName("EvaluationItemRemarksID");

                entity.Property(e => e.EvaluationItemRemarksCode).HasMaxLength(5);

                entity.Property(e => e.EvaluationItemRemarksDescription).HasMaxLength(10);
            });

            modelBuilder.Entity<EvaluationResponse>(entity =>
            {
                entity.ToTable("EvaluationResponse");

                entity.Property(e => e.EvaluationResponseId).HasColumnName("EvaluationResponseID");

                entity.Property(e => e.EvaluatedByPersonId).HasColumnName("EvaluatedByPersonID");

                entity.Property(e => e.EvaluationDate).HasColumnType("date");

                entity.Property(e => e.EvaluationForPersonId).HasColumnName("EvaluationForPersonID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.HasOne(d => d.EvaluatedByPerson)
                    .WithMany(p => p.EvaluationResponseEvaluatedByPeople)
                    .HasForeignKey(d => d.EvaluatedByPersonId)
                    .HasConstraintName("FK_EvaluationResponse_EvaluatedByPerson");

                entity.HasOne(d => d.EvaluationForPerson)
                    .WithMany(p => p.EvaluationResponseEvaluationForPeople)
                    .HasForeignKey(d => d.EvaluationForPersonId)
                    .HasConstraintName("FK_EvaluationResponse_EvaluationForPerson");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EvaluationResponses)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_EvaluationResponse_Semester");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.EvaluationResponses)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_EvaluationResponse_Term");
            });

            modelBuilder.Entity<EvaluationResponseDetail>(entity =>
            {
                entity.HasKey(e => e.EvaluationResponseDetailsId);

                entity.Property(e => e.EvaluationResponseDetailsId).HasColumnName("EvaluationResponseDetailsID");

                entity.Property(e => e.EvaluationItemId).HasColumnName("EvaluationItemID");

                entity.Property(e => e.EvaluationResponseId).HasColumnName("EvaluationResponseID");

                entity.HasOne(d => d.EvaluationItem)
                    .WithMany(p => p.EvaluationResponseDetails)
                    .HasForeignKey(d => d.EvaluationItemId)
                    .HasConstraintName("FK_EvaluationResponseDetails_EvaluationItem");

                entity.HasOne(d => d.EvaluationResponse)
                    .WithMany(p => p.EvaluationResponseDetails)
                    .HasForeignKey(d => d.EvaluationResponseId)
                    .HasConstraintName("FK_EvaluationResponseDetails_EvaluationResponse");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.ThemeColor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Fee>(entity =>
            {
                entity.ToTable("Fee");

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.FeeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeDescription).HasMaxLength(30);

                entity.Property(e => e.FeeTypeId).HasColumnName("FeeTypeID");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.ToTable("FeeType");

                entity.Property(e => e.FeeTypeId).HasColumnName("FeeTypeID");

                entity.Property(e => e.FeeTypeDescription).HasColumnName("FeeTypeDescription");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName).HasMaxLength(15);
            });

            modelBuilder.Entity<GovernmentIssuedIdentification>(entity =>
            {
                entity.ToTable("GovernmentIssuedIdentification");

                entity.Property(e => e.GovernmentIssuedIdentificationId).HasColumnName("GovernmentIssuedIdentificationID");

                entity.Property(e => e.IssuedIdentificationType).HasMaxLength(20);
            });

            modelBuilder.Entity<GradeRemark>(entity =>
            {
                entity.HasKey(e => e.GradeRemarksId);

                entity.Property(e => e.GradeRemarksId).HasColumnName("GradeRemarksID");

                entity.Property(e => e.GradeRemarksCode).HasMaxLength(5);

                entity.Property(e => e.GradeRemarksDescription).HasMaxLength(15);
            });

            modelBuilder.Entity<LeaveApplication>(entity =>
            {
                entity.ToTable("LeaveApplication");

                entity.Property(e => e.LeaveApplicationId).HasColumnName("LeaveApplicationID");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.NoOfDaysAppliedFor).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApplicationStatus)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.ApplicationStatusId)
                    .HasConstraintName("FK__LeaveAppl__Appli__69C6B1F5");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LeaveAppl__Emplo__6501FCD8");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LeaveAppl__Leave__65F62111");
            });

            modelBuilder.Entity<LeaveApplicationStatus>(entity =>
            {
                entity.HasKey(e => e.ApplicationStatusId);

                entity.ToTable("LeaveApplicationStatus");

                entity.Property(e => e.ApplicationStatusId).HasColumnName("ApplicationStatusID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.TotalDaysApproved).HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.ToTable("LeaveType");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.Property(e => e.LeaveTypeDescription).IsUnicode(false);

                entity.Property(e => e.LeaveTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorCode).HasMaxLength(30);

                entity.Property(e => e.MajorName).HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MenuIcon).HasMaxLength(30);

                entity.Property(e => e.MenuLink).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.InverseParentMenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("FK_Menu_ParentMenu");
            });

            modelBuilder.Entity<MidDay>(entity =>
            {
                entity.ToTable("MidDay");

                entity.Property(e => e.MidDayId).HasColumnName("MidDayID");

                entity.Property(e => e.MidDayName).HasMaxLength(5);
            });

            modelBuilder.Entity<Payable>(entity =>
            {
                entity.ToTable("Payable");
                entity.Property(e => e.PayableId).HasColumnName("PayableID");
                entity.Property(e => e.FeeId).HasColumnName("FeeID");
                entity.Property(e => e.TermId).HasColumnName("TermID");
                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");
                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });
            modelBuilder.Entity<PayableTransaction>(entity =>
            {
                entity.ToTable("PayableTransaction");
                entity.Property(e => e.PayableTransactionId).HasColumnName("PayableTransactionID");
                entity.Property(e => e.PayableId).HasColumnName("PayableID");
                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Payable)
                   .WithMany(p => p.PayableTransaction)
                   .HasForeignKey(d => d.PayableId)
                   .HasConstraintName("FK_Payable");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.PayableTransaction)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_Transaction");
            });
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");
                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
                entity.Property(e => e.TransactionNo).HasColumnName("TransactionNo");
                entity.Property(e => e.TransactionDate).HasColumnName("TransactionDate");
                entity.Property(e => e.TotalAmountPayable).HasColumnName("TotalAmountPayable");
                entity.Property(e => e.PaymentAmount).HasColumnName("PaymentAmount");
                entity.Property(e => e.BalancePayable).HasColumnName("BalancePayable");
                entity.Property(e => e.PaymentStatus).HasColumnName("PaymentStatus");
                entity.Property(e => e.FeeTypeId).HasColumnName("FeeTypeID");
                entity.Property(e => e.TermId).HasColumnName("TermID");
                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");
                entity.Property(e => e.StudentId).HasColumnName("StudentID");
                entity.Property(e => e.IsCurrent).HasColumnName("IsCurrent");

                //entity.HasOne(d => d.FeeType)
                //    .WithMany(p => p.PayableTransaction)
                //    .HasForeignKey(d => d.TransactionId)
                //    .HasConstraintName("FK_Transaction");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Birthplace).HasMaxLength(100);

                entity.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

                entity.Property(e => e.CitizenshipId).HasColumnName("CitizenshipID");

                entity.Property(e => e.CivilStatusId).HasColumnName("CivilStatusID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DualCitizenshipAcquisitionId).HasColumnName("DualCitizenshipAcquisitionID");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.NameExtension).HasMaxLength(5);

                entity.Property(e => e.PictureLink).HasMaxLength(150);

                entity.Property(e => e.TelephoneNo).HasMaxLength(20);

                entity.HasOne(d => d.BloodType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.BloodTypeId)
                    .HasConstraintName("FK_Person_BloodType");

                entity.HasOne(d => d.Citizenship)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CitizenshipId)
                    .HasConstraintName("FK_Person_Citizenship");

                entity.HasOne(d => d.CivilStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CivilStatusId)
                    .HasConstraintName("FK_Person_CivilStatus");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Person_CountryNaturalized");

                entity.HasOne(d => d.DualCitizenshipAcquisition)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.DualCitizenshipAcquisitionId)
                    .HasConstraintName("FK_Person_DualCitizenship");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Person_Gender");
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_AddressPerson");
                //entity.HasMany(d => d.PersonUsers)
                //   .WithOne(p => p.Person)
                //   .HasForeignKey(d => d.PersonId)
                //   .HasConstraintName("FK_PersonUser_Person");
            });

            modelBuilder.Entity<PersonChild>(entity =>
            {
                entity.ToTable("PersonChild");

                entity.Property(e => e.PersonChildId).HasColumnName("PersonChildID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.ChildName).HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonChildren)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonChildren_Person");
            });

            modelBuilder.Entity<PersonConfirmationQuestion>(entity =>
            {
                entity.ToTable("PersonConfirmationQuestion");

                entity.Property(e => e.PersonConfirmationQuestionId).HasColumnName("PersonConfirmationQuestionID");

                entity.Property(e => e.CaseStatus).HasMaxLength(20);

                entity.Property(e => e.ConfirmationQuestionId).HasColumnName("ConfirmationQuestionID");

                entity.Property(e => e.DateFiled).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ResponseDetails).HasMaxLength(50);

                entity.HasOne(d => d.ConfirmationQuestion)
                    .WithMany(p => p.PersonConfirmationQuestions)
                    .HasForeignKey(d => d.ConfirmationQuestionId)
                    .HasConstraintName("FK_PersonConfirmationQuestion_ConfirmationQuestion");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonConfirmationQuestions)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonConfirmationQuestion_Person");
            });

            modelBuilder.Entity<PersonEducationalBackground>(entity =>
            {
                entity.ToTable("PersonEducationalBackground");

                entity.Property(e => e.PersonEducationalBackgroundId).HasColumnName("PersonEducationalBackgroundID");

                entity.Property(e => e.AttendancePeriodFrom).HasColumnType("date");

                entity.Property(e => e.AttendancePeriodTo).HasColumnType("date");

                entity.Property(e => e.BasicEducationorDegree).HasMaxLength(70);

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ScholarshipOrAcademicHonors).HasMaxLength(50);

                entity.Property(e => e.SchoolName).HasMaxLength(70);

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.PersonEducationalBackgrounds)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_PersonEducationalBackground_EducationLevel");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonEducationalBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonEducationalBackground_Person");
            });

            modelBuilder.Entity<PersonOathDeclaration>(entity =>
            {
                entity.ToTable("PersonOathDeclaration");

                entity.Property(e => e.PersonOathDeclarationId).HasColumnName("PersonOathDeclarationID");

                entity.Property(e => e.AdministeringOathPerson).HasMaxLength(100);

                entity.Property(e => e.DateAccomplished).HasColumnType("date");

                entity.Property(e => e.DateSworn).HasColumnType("date");

                entity.Property(e => e.GovernmentIssuedIdentificationId).HasColumnName("GovernmentIssuedIdentificationID");

                entity.Property(e => e.Idno)
                    .HasMaxLength(20)
                    .HasColumnName("IDNo");

                entity.Property(e => e.IssuanceDate).HasColumnType("date");

                entity.Property(e => e.IssuancePlace).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Photo).HasMaxLength(50);

                entity.Property(e => e.RightThumbmark).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(50);

                entity.HasOne(d => d.GovernmentIssuedIdentification)
                    .WithMany(p => p.PersonOathDeclarations)
                    .HasForeignKey(d => d.GovernmentIssuedIdentificationId)
                    .HasConstraintName("FK_PersonAuthDeclaration_GovernmentIssuedID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonOathDeclarations)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonAuthDeclaration_Person");
            });

            modelBuilder.Entity<PersonOrganizationMembershipInformation>(entity =>
            {
                entity.ToTable("PersonOrganizationMembershipInformation");

                entity.Property(e => e.PersonOrganizationMembershipInformationId).HasColumnName("PersonOrganizationMembershipInformationID");

                entity.Property(e => e.MembershipDetails).HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonOrganizationMembershipInformations)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonOrganizationMembershipInformation_Person");
            });

            modelBuilder.Entity<PersonParentsFamilyBackground>(entity =>
            {
                entity.ToTable("PersonParentsFamilyBackground");

                entity.Property(e => e.PersonParentsFamilyBackgroundId).HasColumnName("PersonParentsFamilyBackgroundID");

                entity.Property(e => e.FatherFirstName).HasMaxLength(50);

                entity.Property(e => e.FatherMiddleName).HasMaxLength(50);

                entity.Property(e => e.FatherSurname).HasMaxLength(50);

                entity.Property(e => e.MaidenName).HasMaxLength(50);

                entity.Property(e => e.MotherFirstName).HasMaxLength(50);

                entity.Property(e => e.MotherMiddleName).HasMaxLength(50);

                entity.Property(e => e.MotherSurname).HasMaxLength(50);

                entity.Property(e => e.NameExtension).HasMaxLength(5);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonParentsFamilyBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonParentsFamilyBackground_Person");
            });

            modelBuilder.Entity<PersonRecognitionInformation>(entity =>
            {
                entity.ToTable("PersonRecognitionInformation");

                entity.Property(e => e.PersonRecognitionInformationId).HasColumnName("PersonRecognitionInformationID");

                entity.Property(e => e.NonAcademicDistinction).HasMaxLength(120);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonRecognitionInformations)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonRecognitionInformation_Person");
            });

            modelBuilder.Entity<PersonReference>(entity =>
            {
                entity.ToTable("PersonReference");

                entity.Property(e => e.PersonReferenceId).HasColumnName("PersonReferenceID");

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonReferenceAddress).HasMaxLength(100);

                entity.Property(e => e.PersonReferenceName).HasMaxLength(100);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonReferences)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonReference_Person");
            });

            modelBuilder.Entity<PersonServiceEligibility>(entity =>
            {
                entity.ToTable("PersonServiceEligibility");

                entity.Property(e => e.PersonServiceEligibilityId).HasColumnName("PersonServiceEligibilityID");

                entity.Property(e => e.CareerEligibility).HasMaxLength(50);

                entity.Property(e => e.ExaminationDate).HasColumnType("date");

                entity.Property(e => e.ExaminationPlace).HasMaxLength(50);

                entity.Property(e => e.LicenseNo).HasMaxLength(20);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ValidityDate).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonServiceEligibilities)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonServiceEligibility_Person");
            });

            modelBuilder.Entity<PersonSkillsInformation>(entity =>
            {
                entity.ToTable("PersonSkillsInformation");

                entity.Property(e => e.PersonSkillsInformationId).HasColumnName("PersonSkillsInformationID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SkillsHobbies).HasMaxLength(30);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonSkillsInformations)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonSkillsInformation_Person");
            });

            modelBuilder.Entity<PersonSpouseFamilyBackground>(entity =>
            {
                entity.ToTable("PersonSpouseFamilyBackground");

                entity.Property(e => e.PersonSpouseFamilyBackgroundId).HasColumnName("PersonSpouseFamilyBackgroundID");

                entity.Property(e => e.BusinessAddress).HasMaxLength(100);

                entity.Property(e => e.EmployerOrBusinessName).HasMaxLength(100);

                entity.Property(e => e.NameExtension).HasMaxLength(5);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SpouseFirstName).HasMaxLength(50);

                entity.Property(e => e.SpouseMiddleName).HasMaxLength(50);

                entity.Property(e => e.SpouseSurname).HasMaxLength(50);

                entity.Property(e => e.TelephoneNo).HasMaxLength(15);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonSpouseFamilyBackgrounds)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonSpouseFamilyBackground_Person");
            });

            modelBuilder.Entity<PersonTrainingProgram>(entity =>
            {
                entity.ToTable("PersonTrainingProgram");

                entity.Property(e => e.PersonTrainingProgramId).HasColumnName("PersonTrainingProgramID");

                entity.Property(e => e.InclusiveDateFrom).HasColumnType("date");

                entity.Property(e => e.InclusiveDateTo).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.TrainingProgramSponsor).HasMaxLength(100);

                entity.Property(e => e.TrainingProgramTitle).HasMaxLength(100);

                entity.Property(e => e.TrainingProgramTypeId).HasColumnName("TrainingProgramTypeID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonTrainingPrograms)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonTrainingProgram_Person");

                entity.HasOne(d => d.TrainingProgramType)
                    .WithMany(p => p.PersonTrainingPrograms)
                    .HasForeignKey(d => d.TrainingProgramTypeId)
                    .HasConstraintName("FK_PersonTrainingProgram_TrainingProgramType");
            });

            modelBuilder.Entity<PersonUser>(entity =>
            {
                entity.ToTable("PersonUser");

                entity.Property(e => e.PersonUserId).HasColumnName("PersonUserID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonUsers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonUser_Person");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PersonUser_User");
            });

            modelBuilder.Entity<PersonVoluntaryWork>(entity =>
            {
                entity.ToTable("PersonVoluntaryWork");

                entity.Property(e => e.PersonVoluntaryWorkId).HasColumnName("PersonVoluntaryWorkID");

                entity.Property(e => e.InclusiveDateFrom).HasColumnType("date");

                entity.Property(e => e.InclusiveDateTo).HasColumnType("date");

                entity.Property(e => e.OrganizationAddress).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Position).HasMaxLength(20);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonVoluntaryWorks)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonVoluntaryWork_Person");
            });

            modelBuilder.Entity<PersonWorkExperience>(entity =>
            {
                entity.ToTable("PersonWorkExperience");

                entity.Property(e => e.PersonWorkExperienceId).HasColumnName("PersonWorkExperienceID");

                entity.Property(e => e.AgencyOfficeCompany).HasMaxLength(100);

                entity.Property(e => e.AppointmentStatusId).HasColumnName("AppointmentStatusID");

                entity.Property(e => e.InclusiveDateFrom).HasColumnType("date");

                entity.Property(e => e.InclusiveDateTo).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PositionTitle).HasMaxLength(50);

                entity.Property(e => e.SalaryGrade).HasMaxLength(10);

                entity.HasOne(d => d.AppointmentStatus)
                    .WithMany(p => p.PersonWorkExperiences)
                    .HasForeignKey(d => d.AppointmentStatusId)
                    .HasConstraintName("FK_PersonWorkExperience_AppointmentStatus");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonWorkExperiences)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonWorkExperience_Person");
            });

            modelBuilder.Entity<ISMS_API.Models.Program>(entity =>
            {
                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ProgramCode).HasMaxLength(10);

                entity.Property(e => e.ProgramName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramMajor>(entity =>
            {
                entity.ToTable("ProgramMajor");

                entity.Property(e => e.ProgramMajorId).HasColumnName("ProgramMajorID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.ProgramMajors)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_ProgramMajor_Major");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramMajors)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_ProgramMajor_Program");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.FullProjectName).HasMaxLength(70);

                entity.Property(e => e.ProjectCodeName).HasMaxLength(30);

                entity.Property(e => e.ProjectName).HasMaxLength(30);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(20);
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.ToTable("RoleMenu");

                entity.Property(e => e.RoleMenuId).HasColumnName("RoleMenuID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RoleMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_RoleMenu_Menu");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMenus)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleMenu_Role");
            });

            modelBuilder.Entity<RoleProject>(entity =>
            {
                entity.ToTable("RoleProject");

                entity.Property(e => e.RoleProjectId).HasColumnName("RoleProjectID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.RoleProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_RoleProject_Project");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleProjects)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleProject_Role");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.RoomCode).HasMaxLength(15);

                entity.Property(e => e.RoomName).HasMaxLength(20);

                entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomTypeId)
                    .HasConstraintName("FK_Room_RoomType");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.ToTable("RoomType");

                entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

                entity.Property(e => e.RoomTypeDescription).HasMaxLength(15);

                entity.Property(e => e.RoomTypeName).HasMaxLength(10);
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterCode).HasMaxLength(10);

                entity.Property(e => e.SemesterName).HasMaxLength(30);
            });

            modelBuilder.Entity<ShsSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PK__ShsSubje__AC1BA388CF26D9B2");

                entity.ToTable("ShsSubject");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.GradeLevel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrandId).HasColumnName("StrandID");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Strand)
                    .WithMany(p => p.ShsSubjects)
                    .HasForeignKey(d => d.StrandId)
                    .HasConstraintName("FK_SubjectStrand");
            });

            modelBuilder.Entity<ShsSubjectSchedule>(entity =>
            {
                entity.HasKey(e => e.SubjectScheduleId)
                    .HasName("PK__ShsSubje__81ADD8F839530A63");

                entity.ToTable("ShsSubjectSchedule");

                entity.Property(e => e.SubjectScheduleId).HasColumnName("SubjectScheduleID");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.MidDayIdtimeEnd).HasColumnName("MidDayIDTimeEnd");

                entity.Property(e => e.MidDayIdtimeStart).HasColumnName("MidDayIDTimeStart");

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TimeEnd).HasColumnType("time(0)");

                entity.Property(e => e.TimeStart).HasColumnType("time(0)");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.ShsSubjectSchedules)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_SubjectScheduleDay");

                entity.HasOne(d => d.MidDayIdtimeEndNavigation)
                    .WithMany(p => p.ShsSubjectScheduleMidDayIdtimeEndNavigations)
                    .HasForeignKey(d => d.MidDayIdtimeEnd)
                    .HasConstraintName("FK_SubjectScheduleMidDayEnd");

                entity.HasOne(d => d.MidDayIdtimeStartNavigation)
                    .WithMany(p => p.ShsSubjectScheduleMidDayIdtimeStartNavigations)
                    .HasForeignKey(d => d.MidDayIdtimeStart)
                    .HasConstraintName("FK_SubjectScheduleMidDayStart");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.ShsSubjectSchedules)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_SubjectScheduleSemester");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ShsSubjectSchedules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_SubjectSchedule");
            });

            modelBuilder.Entity<Strand>(entity =>
            {
                entity.ToTable("Strand");

                entity.Property(e => e.StrandId).HasColumnName("StrandID");

                entity.Property(e => e.StrandCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StrandName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Lrnno)
                    .HasMaxLength(20)
                    .HasColumnName("LRNNo");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.StudentNo).HasMaxLength(50);

                entity.Property(e => e.YearLevel).HasMaxLength(20);

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_Student_Major");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Student_Person")
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Student_Program");
            });

            modelBuilder.Entity<StudentCourseSchedule>(entity =>
            {
                entity.ToTable("StudentCourseSchedule");

                entity.Property(e => e.StudentCourseScheduleId).HasColumnName("StudentCourseScheduleID");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.CourseSchedule)
                    .WithMany(p => p.StudentCourseSchedules)
                    .HasForeignKey(d => d.CourseScheduleId)
                    .HasConstraintName("FK_StudentSchedule_Schedule");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCourseSchedules)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_StudentSchedule_Student");
            });

            modelBuilder.Entity<StudentGrade>(entity =>
            {
                entity.HasKey(e => e.StudentGradesId);

                entity.Property(e => e.StudentGradesId).HasColumnName("StudentGradesID");

                entity.Property(e => e.FinalGeneralAverage).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.FinalPeriodGrade).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.GradeRemarksId).HasColumnName("GradeRemarksID");

                entity.Property(e => e.MidtermPeriodGrade).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.PrelimPeriodGrade).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.SemiFinalPeriodGrade).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.StudentScheduleId).HasColumnName("StudentScheduleID");

                entity.HasOne(d => d.GradeRemarks)
                    .WithMany(p => p.StudentGrades)
                    .HasForeignKey(d => d.GradeRemarksId)
                    .HasConstraintName("FK_StudentGrades_GradeRemarks");

                entity.HasOne(d => d.StudentSchedule)
                    .WithMany(p => p.StudentGrades)
                    .HasForeignKey(d => d.StudentScheduleId)
                    .HasConstraintName("FK_StudentGrades_StudentSchedule");
            });

            modelBuilder.Entity<StudentType>(entity =>
            {
                entity.ToTable("StudentType");

                entity.Property(e => e.StudentTypeId).HasColumnName("StudentTypeID");

                entity.Property(e => e.StudentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.CollegeId).HasColumnName("CollegeID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.CollegeId)
                    .HasConstraintName("FK_Teacher_College");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Teacher__PersonI__6ABAD62E");
            });

            modelBuilder.Entity<TeacherCourseSchedule>(entity =>
            {
                entity.ToTable("TeacherCourseSchedule");

                entity.Property(e => e.TeacherCourseScheduleId).HasColumnName("TeacherCourseScheduleID");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.CourseSchedule)
                    .WithMany(p => p.TeacherCourseSchedules)
                    .HasForeignKey(d => d.CourseScheduleId)
                    .HasConstraintName("FK_TeacherSchedule_Schedule");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherCourseSchedules)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherSchedule_Teacher");
            });

            modelBuilder.Entity<TeacherShsSubjectSchedule>(entity =>
            {
                entity.ToTable("TeacherShsSubjectSchedule");

                entity.Property(e => e.TeacherShsSubjectScheduleId).HasColumnName("TeacherShsSubjectScheduleID");

                entity.Property(e => e.SubjectScheduleId).HasColumnName("SubjectScheduleID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.SubjectSchedule)
                    .WithMany(p => p.TeacherShsSubjectSchedules)
                    .HasForeignKey(d => d.SubjectScheduleId)
                    .HasConstraintName("FK_TeacherSubject");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherShsSubjectSchedules)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherSchedule");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.ToTable("Term");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.TermCode).HasMaxLength(15);

                entity.Property(e => e.TermName).HasMaxLength(50);
            });

            modelBuilder.Entity<TrainingProgramType>(entity =>
            {
                entity.ToTable("TrainingProgramType");

                entity.Property(e => e.TrainingProgramTypeId).HasColumnName("TrainingProgramTypeID");

                entity.Property(e => e.TrainingProgramTypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<TuitionFeeRate>(entity =>
            {
                entity.ToTable("TuitionFeeRate");

                entity.Property(e => e.TuitionFeeRateId).HasColumnName("TuitionFeeRateID");

                entity.Property(e => e.TuitionFeeRateAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role");
                //entity.HasMany(d => d.PersonUsers)
                //   .WithOne(p => p.User)
                //   .HasForeignKey(d => d.UserId)
                //   .HasConstraintName("FK_PersonUser_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}