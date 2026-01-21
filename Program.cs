using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//Add services
builder.Services.AddControllers();
builder.Services.AddDbContext<ArtArchiveDbContext>(options =>
    options.UseSqlite("Data Source=artarchive.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowVue", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("AllowVue");
app.MapControllers();

app.Run();