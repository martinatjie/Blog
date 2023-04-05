using AutoMapper;
using Blog.Api.Services;
using Blog.Core.Entities;
using Blog.Core.Repositories;
using Blog.Core.Services;
using Blog.Core.DTO;
using Blog.Data;
using Blog.Infrastructure.Repositories;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Blog.Api.Resolvers;

//var mapperConfig = new MapperConfiguration(cfg =>
//{
//    cfg.CreateMap<Post, PostDto>()
//    .ForMember(dest => dest.CommentContents, opt => opt.MapFrom<CommentResolver>()); // map using a custom resolver

//});

//var mapper = mapperConfig.CreateMapper();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add database context to the service container
builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BlogDatabase")));
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
//builder.Services.AddAutoMapper();

// Add logging to the builder
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders(); // Remove the default logging providers
    logging.AddConsole(); // Add the console logging provider
});

var app = builder.Build();

app.UseCors(builder => builder
        .WithOrigins("https://localhost:7062") // <-- Replace with your own domain
        .AllowAnyHeader()
        .AllowAnyMethod()
    );

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
