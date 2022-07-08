using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Utils
{
    public static class ServicesManager
    {
        public static void RegisterServies(WebApplicationBuilder builder)
        {
            //these were defaultly registered
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ToDoContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("ToDoDb")
                    )
            );

            builder.Logging.AddConsole();

        }

        public static void Startup(WebApplication app)
        {

            using (var scope = app.Services.CreateScope())
            {
                SeedData.Seed(scope.ServiceProvider);
            }
        }
    }
}
