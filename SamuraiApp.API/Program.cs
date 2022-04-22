using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SamuraiAPP.Data;
using SamuraiAPP.Data.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());    

//menambah automapper

//efcore
builder.Services.AddDbContext<SamuraiContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SamuraiConnection"))
.EnableSensitiveDataLogging());

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddDefaultTokenProviders().AddEntityFrameworkStores<SamuraiContext>(); 

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddDefaultTokenProviders().AddEntityFrameworkStores<SamuraiContext>();

//injection
builder.Services.AddTransient<ISamurai, SamuraiRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
