var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();


