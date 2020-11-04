using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PS.Template.Application.Services;
using PS.Template.AccessData.Repositories;
using Microsoft.OpenApi.Models;
using PS.Template.API.Entities;
using PS.Template.Domain.Interfaces.Service;
using PS.Template.AccessData.Queries;
using PS.Template.Domain.Interfaces.Queries;
using SqlKata.Compilers;
using System.Data;
using System.Data.SqlClient;
using PS.Template.JWSToken;

namespace PS.Template.API
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
            services.AddMvc();

            var connectionString = Configuration.GetSection("ConnectionString").Value;

            //EF CORE
            services.AddDbContext<SucursalDBContext>(opcion => opcion.UseSqlServer(connectionString));


            //SQLKATA
            services.AddTransient<Compiler, SqlServerCompiler>();
            services.AddTransient<IDbConnection>(s =>
            {
                return new SqlConnection(connectionString);
            });

            //SWAGGER
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "MicroService APIs v1.0",
                    Description = "Test services"
                });
            });

            //CORS
            services.AddCors(c => {
                c.AddPolicy("AllowOrigin", options => options
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });


            services.AddTransient<ISucursalRepository, SucursalRepository>();
            services.AddTransient<IDireccionRepository, DireccionRepository>();
            services.AddTransient<ILocalidadRepository, LocalidadRepository>();

            
            services.AddTransient<ISucursalService, SucursalService>();
            services.AddTransient<IDireccionService, DireccionService>();
            services.AddTransient<ILocalidadService, LocalidadService>();

            services.AddTransient<IDireccionQuery, DireccionQuery>();
            services.AddTransient<ILocalidadQuery, LocalidadQuery>();
            services.AddTransient<ISucursalQuery, SucursalQuery>();

            services.AddJWTAuthentication(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Habilitar swagger
            app.UseSwagger();
            //indica la ruta para generar la configuración de swagger
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api REST");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            //Indicamos a la app utilizar Cors
            app.UseCors(options =>
            {
                options.AllowAnyMethod();
                options.AllowAnyHeader();
                options.AllowAnyOrigin();
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
