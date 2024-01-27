using BaaS.Ioc;
using BaaS.Repositories;
using BaaS.API.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using System.Globalization;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace BaaS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { options.ForwardClientCertificate = false; });

            Repositories.Connections.ConnectionStringManager.EBankConnection = Configuration.GetConnectionString("DatabaseConnectionEBank");
            Repositories.Connections.ConnectionStringManager.InfobankConnection = Configuration.GetConnectionString("DatabaseConnectionInfobank");
            Repositories.Connections.ConnectionStringManager.ContaCorrenteConnection = Configuration.GetConnectionString("DatabaseConnectionContaCorrente");

            services.AddSwaggerGen(c =>
            {
                    
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Swagger Documentação Web API",
                    Description = "Swagger Documentação Web API",
                    License = new OpenApiLicense() { Name = "MIT License", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });

                      

            services.AddMvcCore(options =>
            {
                options.RequireHttpsPermanent = false;
            });

            services.AddControllers().AddJsonOptions(options => {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
                
            });


            services.AddMvcCore(options =>
            {
                options.RequireHttpsPermanent = false;

            });
            services.AddMvcCore().AddApiExplorer();
            services.AddMvcCore().AddNewtonsoftJson(JsonSettings.SetJsonOptions);

            IntegrateSimpleInjector(services);
        }


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

            app.UseSimpleInjector(ContainerBuilder.Container());

            // Definindo a cultura padrão: pt-BR
            CultureInfo[] supportedCultures = new[] { new CultureInfo("pt-BR") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            
            app.UseSwagger();
            app.UseSwaggerUI();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint($"v1/swagger.json", "BaaS");
                
            //});

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
            ContainerBuilder.Container().Verify();
            //app.UseMvc();
            
        }

        private static void IntegrateSimpleInjector(IServiceCollection services)
        {
            services.AddSimpleInjector(ContainerBuilder.Container(), options =>
            {
                options.AddAspNetCore().AddControllerActivation();
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(ContainerBuilder.Container()));

            services.UseSimpleInjectorAspNetRequestScoping(ContainerBuilder.Container());
        }
    }
}
