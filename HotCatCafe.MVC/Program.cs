using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.BLL.Repositories.Concretes;
using HotCat.BLL.Repositories.Concretes.BaseConcrete;
using HotCat.DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection Services

//AddDbContext
builder.Services.AddDbContext<HotCatContext>(options => options.UseSqlServer("server=DESKTOP-JSABNAD\\SQLEXPRESS; database=HotCatProjem; Trusted_Connection=True;TrustServerCertificate=true"));

//Repository Services

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

//Entity Services
builder.Services.AddScoped<ICategoryService, CategoryService>();












var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
