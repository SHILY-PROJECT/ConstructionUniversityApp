using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Application.Configuration;
using ConstructionUniversity.Infrastructure.Configuration;
using ConstructionUniversity.WebApi.Configuration;

namespace ConstructionUniversity.WebApi;

public class Startup
{
    private const string Title = "ConstructionUniversity";
    private const string Version = "v1";

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddControllers()
            .AddFluentValidation();

        services
            .AddApplication()
            .AddInfrastructure(
                Configuration.GetConnectionString("ConstructionUniversityDb"),
                Configuration.GetSection("DatabaseCreationSettings").Get<DatabaseCreationSettings>())
            .AddWebApi();
        
        services.AddSwaggerGen(c => c.SwaggerDoc(Version, new OpenApiInfo { Title = $"{Title}.API", Version = Version }));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{Version}/swagger.json", $"{Title}.API {Version}"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}