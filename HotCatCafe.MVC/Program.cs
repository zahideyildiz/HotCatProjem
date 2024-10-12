using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.BLL.Repositories.Concretes;
using HotCat.BLL.Repositories.Concretes.BaseConcrete;
using HotCat.DAL.Context;
using HotCat.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HotCat.IOC.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Configuration.GetConnectionString("DefaultConnection");

//Dependency Injection Services
//AddDbContext

builder.Services.AddHotCatDb();





//builder.Services.AddDbContext<HotCatContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("HotCatCafe.MVC")));
//builder.Services.AddDbContext<HotCatContext>(options => options.UseSqlServer("server=DESKTOP-JSABNAD\\SQLEXPRESS; database=HotCatProjem; Trusted_Connection=True;TrustServerCertificate=true", b => b.MigrationsAssembly("HotCatCafe.MVC")));


//Repository Services
builder.Services.AddRepositoryService();


//User Manager

builder.Services.AddIdentityService();

//Session



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
//session

app.UseAuthorization(); //yetkilendirme
//app.UseAuthentication(); //kimlik yönetimi

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );


//    endpoints.MapControllerRoute(
//  name: "activationUrl",
//  pattern: "{controller=Home}/{action=Activation}/{id}/{token}"
//);


    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
);

});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
