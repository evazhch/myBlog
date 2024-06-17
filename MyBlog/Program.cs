using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyBlog.BLL.Sys;
using MyBlog.Common.Model;
using MyBlog.DAL;
using MyBlog.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
builder.Services.AddScoped<SysUserLogic>();
builder.Services.AddDbContext<SysDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("BloggingContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();// 开发人员异常页
}

app.UseExceptionHandler();//异常处理中间件

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
