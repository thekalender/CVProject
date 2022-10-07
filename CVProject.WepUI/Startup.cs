using CVProject.Business.Abstract;
using CVProject.Business.Concrete;
using CVProject.DataAccess.Abstract;
using CVProject.DataAccess.Concrate.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.WepUI
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
            services.AddRazorPages();
            services.AddSingleton<IAboutDal, EfAboutDal>();
            services.AddSingleton<IAboutService, AboutManager>();

            services.AddSingleton<IAwardDal, EfAwardDal>();
            services.AddSingleton<IAwardService, AwardManager>();

            services.AddSingleton<IEducationDal, EfEducationDal>();
            services.AddSingleton<IEducationService, EducationManager>();

            services.AddSingleton<IExperienceDal, EfExperienceDal>();
            services.AddSingleton<IExperienceService, ExperienceManager>();

            services.AddSingleton<IInterestDal, EfInterestDal>();
            services.AddSingleton<IInterestService, InterestManager>();

            services.AddSingleton<ISkillDal, EfSkillDal>();
            services.AddSingleton<ISkillService, SkillManager>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // KSoft_Ahk_start
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "CVPProject",
                    pattern: "{controller=CVPProject}/{action=Index}/{id?}");
            });
            //KSoft_Ahk_end
        }
    }
}
