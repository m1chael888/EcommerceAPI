
using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddDbContext<EcomContext>(x => x.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
