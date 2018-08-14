using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicWeb.Services;
using System.IO;

namespace MusicWeb
{
    public class Startup
    {
        public IConfiguration configuration;
        public Startup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("dummy.json");
            configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IMessageService, ConfigurationMessageService>().AddSingleton(provider => configuration);
            services.AddScoped<IMusicData, MockMusicData>();
            //services.AddSingleton(provider => configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IMessageService msg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();
            app.UseMvc(routes => { routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{Id?}"); });
            //app.UseMvc();
            app.Run(async (context) =>
            {
                //var message = configuration["Message"];
                //throw new Exception("Fake Exception!");
                await context.Response.WriteAsync(msg.GetMessage());
            });
        }
    }
}
