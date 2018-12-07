using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HAC.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HAC
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<HacContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            #region Admin User Initilization
            // On startup of program make sure DB isn't empty. If it is empty Add users
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HacContext>();

                if (context.Users.Count() <= 0)
                {
                    context.Users.AddRange(
                         new User
                         {
                             Name = "Admin",
                             RegisterDate = DateTime.Now,
                             Crendtials = "Admin",
                             Password = "Password123"
                         }

                    );
                    context.SaveChanges();
                }
            }
            #endregion


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
