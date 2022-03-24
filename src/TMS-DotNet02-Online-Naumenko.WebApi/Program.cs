using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Logic.Services;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MainContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDbConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ITermService, TermService>();
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<IOptionService, OptionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.Run();
