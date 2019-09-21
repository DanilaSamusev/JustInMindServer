using JustInMindServer.Models;
using JustInMindServer.Repositories;
using JustInMindServer.Repositories.Implementations;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JustInMindServer
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
            
            string connectionString = Configuration.GetConnectionString("ConnectionString");

            services.AddSingleton<TicketRepository>();
            
            services.AddSingleton<ITicketRepository, TicketRepository>();
            services.AddSingleton<IRepository<User>, UserRepository>();
            services.AddSingleton<IRepository<History>, HistoryRepository>();
            services.AddSingleton<IRepository<Feedback>, FeedbackRepository>();
            services.AddSingleton<IRepository<Comment>, CommentRepository>();

            services.AddCors(options => options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000").AllowCredentials();
                }));
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseCors("CorsPolicy");
            app.UseMvc();
        }
    }
}