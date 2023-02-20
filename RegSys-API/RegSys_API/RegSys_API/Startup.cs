using ISMS_API.Data;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ISMS_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();
            services.AddControllers();
            //configure DBContext
            services.AddDbContext<RegSysDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RegSysDB")));
            //configure strongly typed settings objects
            var appSettingSection = Configuration.GetSection("AppSettings");
            services.Configure<DaemonConfig>(appSettingSection);
            //add authentication configuration here

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RegSys_API", Version = "v1.0" });
            });
            services.AddAutoMapper(typeof(Startup));

            //add dependency injection (DI) configuration here
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ICollegeService, CollegeService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IProgramService, ProgramService>();
            services.AddScoped<IMajorService, MajorService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeClassificationService, EmployeeClassificationService>();
            services.AddScoped<IEvaluationCriteriaService, EvaluationCriteriaService>();
            services.AddScoped<IBarangayService, BarangayService>();
            services.AddScoped<ICourseTypeService, CourseTypeService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressTypeService, AddressTypeService>();
            services.AddScoped<IBarangayService, BarangayService>();
            services.AddScoped<IProvinceService, ProvinceService>();
            services.AddScoped<ICityMunicipalityService, CityMunicipalityservice>();
            services.AddScoped<ICourseScheduleService, CourseScheduleService>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();
            services.AddScoped<IEnrollmentCourseScheduleService, EnrollmentBlockService>();
            services.AddScoped<ITermService, TermService>();
            services.AddScoped<ISemesterService, SemesterService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IPayableService, PayableService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<IFeeTypeService, FeeTypeService>();
            services.AddScoped<IPayableTransactionService, PayableTransactionService>();
            services.AddScoped<IBlockService, BlockService>();
            services.AddScoped<IBlockCourseScheduleService, BlockCourseScheduleService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IPersonUserService, PersonUserService>();
            services.AddScoped<ITeacherCourseScheduleService, TeacherCourseScheduleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ISMS_API v1"));
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}