using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using DDDCommerceBCC.Infra.Data;
using DDDCommerceBCC.Infra.Interfaces;
using DDDCommerceBCC.Infra.Repositories;

namespace DDDCommerceBCC.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddDbContext<AppDbContext>();
            
            Env.Load();
            
            builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
            builder.Services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();
            
            // Add services to the container.
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

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            
            app.Run();    
        }
    }
}