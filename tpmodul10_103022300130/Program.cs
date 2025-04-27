var builder = WebApplication.CreateBuilder(args);

// Tambahkan service untuk Controllers dan Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Konfigurasi SwaggerGen dengan OpenApiInfo eksplisit
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Mahasiswa API",
        Version = "v1",
        Description = "API untuk mengelola data mahasiswa"
    });
});

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mahasiswa API V1");
        c.RoutePrefix = "swagger"; 
    });
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();