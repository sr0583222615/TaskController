using TaskController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ItaskService, TaskService>();

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
app.UseMiddlewareTask();
app.MapControllers();

app.MapPost("add", () => "hi Pnini");
app.MapPost("add", async (ILogger<TaskService> Logger, HttpResponse res) =>
{
    Logger.LogInformation("testing ligging in program");
    await res.WriteAsync("testing");
});
app.Run();
