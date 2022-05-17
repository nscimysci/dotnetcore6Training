using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using trainingSplitProject.gulf.model;
using trainingSplitProject.gulf.repositories.entities;
using trainingSplitProject.gulf.business.core;
using trainingSplitProject.gulf.business;


var builder = WebApplication.CreateBuilder(args);

var _AppSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();
builder.Services.AddSingleton(_AppSettings);


var conEncode = builder.Configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");
var conDecodeByte = System.Convert.FromBase64String(conEncode);
var conDecode = System.Text.Encoding.UTF8.GetString(conDecodeByte);

builder.Services.AddDbContext<AZUREDBEBIDDINGDEVContext>(options => options.UseSqlServer(conDecode));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Training Gulf", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                            }
                        },
                        new string[] { }

                    }
                });
});


var key = Encoding.ASCII.GetBytes(_AppSettings.SecretKey);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(x =>
        {
            x.Audience = builder.Configuration["AAD:ResourceId"];
            x.Authority = $"{builder.Configuration["AAD:InstanceId"]}{builder.Configuration["AAD:TenanatId"]}";
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });


builder.Services.AddScoped<IMasterLogic, MasterLogic>();
builder.Services.AddScoped<IAccoutLogic, AccoutLogic>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
