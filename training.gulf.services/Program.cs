using training.gulf.services.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AZUREDBEBIDDINGDEVContext>(options =>
    options.UseSqlServer("Server=tcp:gulfazuredbserver.public.2b353710e0cd.database.windows.net,3342;Persist Security Info=False;User ID=ebiddingusrdev;Password=ebiddingusrdev@gu1f! ; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; Database=AZUREDB-EBIDDING-DEV; "));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Training Gulf", Version = "v1" })
);

var app = builder.Build();

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
