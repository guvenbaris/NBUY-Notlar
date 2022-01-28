using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Middleware.Middlewares;

namespace Middleware
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Middleware", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Middleware v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.Run();
            // async bir öncekinin sonucunu beklemeden çalýþmaya devam eder 
            // Run asenkron çalýþýr. Kendinden sonra ki middleware lar çalýþmaz.
            //app.Run(async context => Console.WriteLine("Middleware 1."));
            //app.Run(async context => Console.WriteLine("Middleware 2."));


            //app.Use();
            //kendi iþlemini yapýyor next invoke methodu ile benden sonra ki middleware 
            //çalýþssýn diyor. Eðer sizin invoke Methodunun altýnda çalýþacak kodlarýnýz varsa
            // bir sonra ki middleware bittikten sonra geriye dönüp kaldýðý yerden çalýþmaya devam eder.

            // await asenkron olsa da bir öncekinin sonucunu beklemesini söyler
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Middleware 1 baþladý.");
            //    await next.Invoke();
            //    Console.WriteLine("Middleware 1 sonlandýrýlýyor.");
            //});

            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Middleware 2 baþladý.");
            //    await next.Invoke();
            //    Console.WriteLine("Middleware 2 sonlandýrýlýyor.");
            //});
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Middleware 3 baþladý.");
            //    await next.Invoke();
            //    Console.WriteLine("Middleware 3 sonlandýrýlýyor.");
            //});

            //app.Map(); Route a göre middleware larý yönetmemizi saðlýyor.

            app.UseHello();

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Use Middleware tetiklendi");
                await next.Invoke();
            });

            app.Map("/example", internalApp => internalApp.Run(async context =>
            {
                Console.WriteLine("/example middleware tetiklendi.");
                await context.Response.WriteAsync("/example middleware tetiklendi.");
            }));

            //app.MapWhen() 
            // Request in içerisinde ki herhangi bir parametreye göre middlewera çalýþtýrabiliriz.
            //app.MapWhen(x => x.Request.Method == "GET", internalApp =>
            //{
            //    internalApp.Run(async context =>
            //    {
            //        Console.WriteLine("MapWhen tetiklendi");
            //        await context.Response.WriteAsync("MapWhen middleware tetiklendi");
            //    });
            //});


             
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
 