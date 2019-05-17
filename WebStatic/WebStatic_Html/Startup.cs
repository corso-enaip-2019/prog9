using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace WebStatic_Html
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use(async(context,next) =>
            {
                if(context.Request.Method == "POST")
                {
                    using(var r = new StreamReader(context.Request.Body))
                    {
                        var body = await r.ReadToEndAsync();
                    }
                    context.Request.Method = "GET";
                    context.Request.Path = "/message-sent.html";
                }
                await next();
            });
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
