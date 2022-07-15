using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model.Requests;
using eRestoran.Services;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Filters;
using eRestoran.WebAPI.Security;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eRestoran.WebAPI
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
            services.AddDbContext<eRestoranContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("eRestoran")));
            services.AddControllers(x => x.Filters.Add<ErrorFilter>());
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper(typeof(Startup));
           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eRestoran API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "basic"
                              }
                          },
                          new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            
            services.AddScoped<IJeloService, JeloService>();
            services.AddScoped<IPreporukaService, PreporukeService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Gradovi, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>, GradService>();
            services.AddScoped<ICRUDService<Model.Kategorije, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>, KategorijaService>();
            services.AddScoped<IBaseService<Model.Uloge, object>, UlogeService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
            services.AddScoped<ICRUDService<Model.NarudzbaDetalji, NarudzbaDetaljiSearchRequest, NarudzbaDetaljiUpsertRequest, NarudzbaDetaljiUpsertRequest>, NarudzbaDetaljiService>();
            services.AddScoped<ICRUDService<Model.Likes, LikesSearchRequest, LikesUpsertRequest, LikesUpsertRequest>, LikesService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
