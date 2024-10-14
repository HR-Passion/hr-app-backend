
using AplicationLayer.AutomapProfiles;
using InfrastructureLayer.Handlers.Groups;
using InfrastructureLayer.Handlers.Permissions;
using InfrastructureLayer.Handlers.Roles;
using InfrastructureLayer.Handlers.Users;
using InfrastructureLayer.Repositories;
using InfrastructureLayer.Repositories.UserRepository;
using InfrastructureLayer.Services.AuthService;
using InfrastructureLayer.Services.GroupService;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
using DataAccesLayer.Repositories;
using DataAccesLayer.Repositories.UserRepository;
using DataAccesLayer.Repositories.RoleRepository;
using DataAccesLayer.Repositories.PermissionRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

    // Definirea autentificării Bearer Token în Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    // Configurarea Swagger pentru a adăuga automat Bearer Token în fiecare request
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

//builder.Services.AddDbContext<DataBaseContext>(options => options.UseInMemoryDatabase("InMem"));
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserHandler,UserHandler>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleHandler, RoleHandler>();
builder.Services.AddScoped<IPermissionHandler,PermissionHandler>();
builder.Services.AddScoped<IPermissionRepository,PermissionRepository>();
builder.Services.AddScoped<IGroupHandler,GroupHandler>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
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
//PrepDb.PrepPopulation(app);
//use middleware
  app.UseMiddleware<JwtGroupMiddleware>();

//implement a pipeline middleware that gets the jwt and gets de group id , so u know later what group ur working on 
app.Run();
