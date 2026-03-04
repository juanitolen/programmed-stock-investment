using Microsoft.EntityFrameworkCore;
using CompraProgramadaAcoes.Data;
using CompraProgramadaAcoes.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL("server=localhost;database=investimento;user=root;password=root1234"));

builder.Services.AddScoped<PurchaseService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();