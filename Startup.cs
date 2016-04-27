using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using Nancy;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.Http.Cors;
using CommonDataService.Models;

namespace SelfHostedWebApiDataService
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            var corsAttr = new EnableCorsAttribute("*", "*", "*", null);

            config.EnableCors(corsAttr);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<ChangeMeasure>("ChangeMeasure");
            builder.EntitySet<Account>("Account");
            builder.EntitySet<AccountAlia>("AccountAlias");
            builder.EntitySet<AccountTool>("AccountTools");
            builder.EntitySet<Role>("Role");
            builder.EntitySet<Person>("Person");
            builder.EntitySet<Service>("Service");
            builder.EntitySet<AccountRolePerson>("AccountRolePerson");
            builder.EntitySet<AccountProgram>("AccountProgram");
            builder.EntitySet<CommonDataService.Models.Program>("Program");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());


            // Adding to the pipeline with our own middleware
            app.Use(async (context, next) =>
            {
                // Add Header
                context.Response.Headers["Product"] = "Common Data Service";

                // Call next middleware
                await next.Invoke();
            });
            
            // Custom Middleare
            app.Use(typeof(SelfHostedWebApiDataService.CustomMiddleware));
            
            // Web Api
            app.UseWebApi(config);

            // File Server
            var options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                DefaultFilesOptions = { DefaultFileNames = {"index.html"}},
                FileSystem = new PhysicalFileSystem("Assets"),
                StaticFileOptions = { ContentTypeProvider = new SelfHostedWebApiDataService.CustomContentTypeProvider() }
            };

            app.UseFileServer(options);

            // Nancy
            app.UseNancy();
        }
    }
}
