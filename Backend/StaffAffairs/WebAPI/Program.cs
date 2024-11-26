
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Services;
using StaffAffairs.BusinessLogic.Services;
using StaffAffairs.DataLayer.DBContext;
using StaffAffairs.DataLayer.Models;
using System.Globalization;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Set default culture to invariant
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            // Add services to the container.
            builder.Services.AddDbContext<StuffAppAppttContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("Ibro")));


             builder.Services.AddScoped<IService<Dept>, Service<Dept>>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
