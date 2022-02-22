using Dogecoin.Api.Service.Endpoint.BusinessRules;
using Dogecoin.Api.Service.Endpoint.BusinessRules.Interface;
using Dogecoin.Api.Service.Endpoint.Swagger;
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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint
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
            services.AddMvc()
            .AddJsonOptions(options => {
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });
            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.SuppressModelStateInvalidFilter = true;
            });

            services.AddControllers();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews()
            .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddTransient<Random>();
            services.AddMemoryCache();
            services.AddOptions();

            #region BusinessRules
            services.AddTransient<IDogecoinBusinessRules, DogecoinBusinessRules>();
            #endregion BusinessRules

            #region swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Dogecoin wallet api"
                });

                c.DocInclusionPredicate((docName, apiDesc) => !string.IsNullOrWhiteSpace(apiDesc?.GroupName));

                c.OperationFilter<SwaggerJsonIgnore>();
                c.OperationFilter<SwaggerDefaultValues>();

                //// integrate xml comments
                c.IncludeXmlComments(XmlCommentsFilePath);

                //// allows same class names in different namespaces
                c.CustomSchemaIds(x => x.FullName);

                c.SchemaFilter<SwaggerExcludeFilter>();
            });
            services.AddSwaggerGenNewtonsoftSupport();
            #endregion  swagger
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("swagger/v1/swagger.json", "Dogecoin wallet api");
                c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private string XmlCommentsFilePath
        {
            get
            {
                var basePath = AppContext.BaseDirectory;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
    }
}
