
using Microsoft.Extensions.FileProviders;
using ToDoList.Utils;

var builder = WebApplication.CreateBuilder(args);


//services are registered in this method to keep program.cs clear
ServicesManager.RegisterServies(builder);

var app = builder.Build();

//some startup procedures (seeding data or sth) gonna be executed in this method
ServicesManager.Startup(app);



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( c =>
         c.InjectStylesheet("SwaggerDark.css")
        );
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "wwwroot")),
    RequestPath = ""
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
