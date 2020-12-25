using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StuHubSystem.DataObject.Entities;
using StuHubSystem.Contract.Interfaces;
using StuHubSystem.Core.Database;
using StuHubSystem.Repo.VietNamLocation;
using StuHubSystem.Contract.Interfaces.SubjectInterfaces.CollegeSubjectInterfaces;
using StuHubSystem.Repo.Subjects.College;

namespace StuHubSystem
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
            services.AddControllers();
            services.AddDbContextPool<StuHubContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StuhubContext")));
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICollegeSubjectRequestRepository, CollegeSubjectRequestRepository>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
