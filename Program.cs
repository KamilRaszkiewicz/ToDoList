
var builder = WebApplication.CreateBuilder(args);


//services are registered in this method to keep program.cs clear
ToDoList.ServicesManager.RegisterServies(builder);

var app = builder.Build();

//some startup procedures (seeding data or sth) gonna be executed in this method
ToDoList.ServicesManager.Startup(app);



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
