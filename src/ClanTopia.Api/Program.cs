global using FastEndpoints;
global using FluentValidation;
using FastEndpoints.Swagger;

namespace ClanTopia.Api
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddFastEndpoints();
            builder.Services.SwaggerDocument();

            var app = builder.Build();
            app.UseFastEndpoints();
            app.UseSwaggerGen();
            app.Run();
        }
    }
}
