using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Mymidlewarexp
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
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();



            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("this First coming from middle ware request  pipeline \n");
                await next.Invoke();
                await context.Response.WriteAsync("this is coming from middle ware  response pipeline \n");



            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("this Second coming from middle ware request  pipeline \n");
                await next.Invoke();
                await context.Response.WriteAsync("this is coming from middle ware  response pipeline \n\n\n");



            });

            app.Run(async (context) =>
            {

                await context.Response.WriteAsync("this terminating coming from middle ware  response pipeline\n\n\n ");



            });





            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
