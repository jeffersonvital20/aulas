using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using modulo1.Services;
using Microsoft.Extensions.FileProviders;

namespace modulo1
{
    public class Startup
    {
        public IConfiguration _config{ get; set;}
        
        public Startup()
        {
            var build = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _config = build.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IMensagemService,TextoMensagemService>();
            services.AddSingleton(provider => _config);
            services.AddSingleton<IMensagemService, ConfigurationMensagemService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMensagemService msg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),@"Arquivos")),
                   RequestPath = new PathString("/Arquivos") 
                
            });

            app.Run(async (context) =>
            {
                //  var mensagem = _config["Mensagem"];
                //var conexao = _config["ConnectionStrings:DefaultConnection"];
                //await context.Response.WriteAsync(mensagem);
                await context.Response.WriteAsync(msg.getMensagem());
            });
           
            
        }
    }
}
