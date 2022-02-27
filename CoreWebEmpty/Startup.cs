using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebEmpty.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreWebEmpty
{
    public class Startup
    {
        private IConfiguration _config;

        //Inject IConfiguration to read key from config files
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //added MVC Service to the dependency container service
            //services.AddMvcCore(); //this service is internaly called by AddMvc();

            //dependency injection
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
                               ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // app.UseFileServer();
            //app.UseMvcWithDefaultRoute(); //added MVC Middleware

            // ===============================================================================
            //Conventional Routing
            app.UseMvc(routes =>
            {
                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute("default", "{controller=Employee}/{action=Index}/{id?}");
            });


            // Commenting this as we dont need to write anything on the webpage and show static files to display data
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});

            // ===============================================================================
            // Environment Settings read from LaunchSettings.json or OS Env Variables
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT") || env.IsEnvironment("QA"))
            //{
            //    var Name = env.EnvironmentName;
            //    app.UseExceptionHandler("/Error");
            //}

            ////app.UseFileServer(); //Commented this is to write the Env Name on Response object and display on browser
            //app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World ==> EnvironmentName: " + env.EnvironmentName);
            //});



            // ===============================================================================
            // Developer Exception Page Middle Ware 
            // navigate to some abc.html file and check yellow screen of death http://localhost:4497/abc.html?a=101&b=Raj

            //if (env.IsDevelopment())
            //{
            //    DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
            //    {
            //        //SourceCodeLineCount = 1
            //        SourceCodeLineCount = 10 //number of line of code before/after the exect error code
            //    };
            //    app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            //}

            //app.UseFileServer();

            //app.Run(async (context) =>
            //{
            //    throw new Exception("Some Error occured while processing the request. Please contact admin.");
            //    await context.Response.WriteAsync("Hello World");
            //});


            // ===============================================================================
            // Multiple Middleware have static files (html, css, js, images) and default files with UseFileServer middleware
            // with option to customize our own file as default

            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("customdefault.html");

            ////app.UseDefaultFiles(); //this both can be replaced with UseFileServer middleware
            ////app.UseStaticFiles(); //this both can be replaced with UseFileServer middleware
            ////app.UseFileServer();
            //app.UseFileServer(fileServerOptions);

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});

            // ===============================================================================
            // Multiple Middleware have static files (html, css, js, images) and default files
            // with option to customize our own file as default

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("customdefault.html");
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});

            // ===============================================================================
            // Multiple Middleware have static files (html, css, js, images) and default files 
            //app.UseDefaultFiles();
            //app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});

            // ===============================================================================
            // Multiple Middleware With Logger to understand the flow of middleware execution
            // Check Output/Debug window for Log Information
            // Output is same as below: 
            //CoreWebEmpty.Startup:Information: MW1: Incoming Request!
            //CoreWebEmpty.Startup:Information: MW2: Incoming Request!
            //CoreWebEmpty.Startup:Information: MW3: Incoming Request and Outgoing Request!
            //CoreWebEmpty.Startup:Information: MW2: Outgoing Request!
            //CoreWebEmpty.Startup:Information: MW1: Outgoing Request!

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW1: Incoming Request!");
            //    await next();
            //    logger.LogInformation("MW1: Outgoing Request!");

            //});

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW2: Incoming Request!");
            //    await next();
            //    logger.LogInformation("MW2: Outgoing Request!");
            //});

            //app.Run(async (context) =>
            //{
            //    logger.LogInformation("MW3: Incoming Request and Outgoing Request!");
            //    await context.Response.WriteAsync("MW3: Incoming Request and Outgoing Request!");
            //});

            // ===============================================================================
            // Multiple Middleware

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello World from 1st Middleware!");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World from 2nd Middleware!");
            //});


            // ===============================================================================
            // Simple Hello World and Server Name
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World! ProcessName: " 
            //        + System.Diagnostics.Process.GetCurrentProcess().ProcessName 
            //        + " ConfigValue ==> " + _config["MyKey"]);
            //});


        }
    }
}
