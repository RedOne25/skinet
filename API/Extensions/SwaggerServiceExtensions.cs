using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Skinet API", Version = "v1"});
            });

            return services;
        }
    }
    
    //public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseSwaggerDocumention(this Microsoft.AspNetCore.Builder.IApplicationBuilder application)
    //{
    //    application.UseSwagger();
    //    application.UseSwaggerUI(c =>
    //    {
    //        c
    //            .SwaggerEndpoint("/swagger/v1/swagger.json", "SkiNet API v1");
    //    });

    //    return app;
    //}

}
