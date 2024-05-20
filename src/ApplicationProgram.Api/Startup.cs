using ApplicationProgram.Infrastructure;
using Autofac;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ApplicationProgram.Api.AutofacModules;

namespace ApplicationProgram.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen();
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly(typeof(AppDbContext).GetTypeInfo().Assembly.GetName().Name);
                    }));

            services.AddMediatR(typeof(Application.Handlers.BaseResponse).GetTypeInfo().Assembly);

            services.AddAutoMapper(
                options =>
                {
                    options.AllowNullCollections = true;
                },
                Assembly.GetAssembly(typeof(Api.Models.BaseResponse)));
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<PersistenceModule>();
            builder.RegisterModule<MediatorModule>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
