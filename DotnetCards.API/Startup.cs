using DotnetCards.Service.Services;
using DotnetCards.Core.Repositories;
using DotnetCards.Core.Services;
using DotnetCards.Core.UnitOfWorks;
using DotnetCards.Data;
using DotnetCards.Data.Repositories;
using DotnetCards.Data.UnitofWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using DotnetCards.API.Filters;
using DotnetCards.API.DTOs;
using DotnetCards.API.Extensions;
using FluentValidation.AspNetCore;
using FluentValidation;
using DotnetCards.API.Validation;

namespace DotnetCards.API
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
            services.AddControllers(options => options.Filters.Add(new ValidationFilter()));

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConStr"].ToString(), o => {
                    o.MigrationsAssembly("DotnetCards.Data");
                });
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "DotnetCards API",
                    Description = ""
                });
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IUnitOfWork, UnitOfWorks>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostDetailService, PostDetailService>();

            services.Configure<ApiBehaviorOptions>(options =>
                options.SuppressModelStateInvalidFilter = true
            ).AddFluentValidation(fv => fv.DisableDataAnnotationsValidation = true);

            services.AddTransient<IValidator<PostCreateDto>, PostCreateValidator>();
            services.AddTransient<IValidator<PostUpdateDto>, PostUpdateValidator>();
            services.AddTransient<IValidator<PostDetailCreateDto>, PostDetailCreateValidator>();
            services.AddTransient<IValidator<PostDetailUpdateDto>, PostDetailUpdateValidator>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DotnetCards API");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCustomException();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
