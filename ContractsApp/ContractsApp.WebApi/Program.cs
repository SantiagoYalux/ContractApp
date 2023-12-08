using ContractsApp.Helper.AutoMapper;
using ContractsApp.Repository.DBContext;
using ContractsApp.Repository.GenericInterfaces;
using ContractsApp.Repository.GenericServices;
using ContractsApp.Service.Interfaces;
using ContractsApp.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//MySql connection string
var mySqlConnection = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<ContractcourseDbContext>(options =>
{
    options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection));
});

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddTransient(typeof(IGenericRepository<>), 
                              typeof(GenericRepository<>));

builder.Services.AddScoped<IContractService, ContractService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("LocalPolicy", builder =>
    {
        builder.AllowAnyOrigin()
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


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseCors("LocalPolicy");
}

app.UseAuthorization();

app.MapControllers();

app.Run();
