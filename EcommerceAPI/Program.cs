
namespace EcommerceAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        // builder.Services.AddScoped();

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
