using Microsoft.EntityFrameworkCore;
using CompraProgramadaAcoes.Data;
using CompraProgramadaAcoes.Services;
using CompraProgramadaAcoes.Domain;

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


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!db.Assets.Any())
    {
        db.Assets.AddRange(
            new Asset { Ticker = "PETR4", Price = 18.50m },
            new Asset { Ticker = "VALE3", Price = 75.30m },
            new Asset { Ticker = "ITUB4", Price = 23.40m },
            new Asset { Ticker = "WEGE3", Price = 35.10m },
            new Asset { Ticker = "BBDC4", Price = 22.00m }
        );

        db.SaveChanges();
    }
}

app.Run();