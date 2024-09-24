using HotCat.DAL.Context;
using HotCat.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HotCat.IOC.DependencyResolvers
{
    public static class IdentityService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppUserRole>()
                    .AddEntityFrameworkStores<HotCatContext>()
                    .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(x =>
            {
                x.Password.RequireDigit = true; //En az 1 rakam olmak zorunda
                x.Password.RequireNonAlphanumeric = true; //En az 1 sayı ve numara hariç karakter olmak zorunda
                x.Password.RequireUppercase = true; //En az 1 büyük harf olmak zorunda
                x.Password.RequireLowercase = true; //En az 1 küçük harf olmak zorunda
                x.Password.RequiredLength = 7; //Minimum şifre uzunluğu
            });

            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.LoginPath = new PathString("/Home/Login");
                //cookie.AccessDeniedPath = new PathString("/Home/Denied");
                cookie.Cookie = new CookieBuilder { Name = "HotCatCookie" };
                cookie.SlidingExpiration = true; //süresi olması lazım
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(1); //1 dakika sonra kaldırsın
            });

            return services;
        }
    }
}

/*
 


builder.Services.Configure<IdentityOptions>(x =>
{
    x.Password.RequireDigit = true; //En az 1 rakam olmak zorunda
    x.Password.RequireNonAlphanumeric = true; //En az 1 sayı ve numara hariç karakter olmak zorunda
    x.Password.RequireUppercase = true; //En az 1 büyük harf olmak zorunda
    x.Password.RequireLowercase = true; //En az 1 küçük harf olmak zorunda
    x.Password.RequiredLength = 7; //Minimum şifre uzunluğu
});


//Cookie Configuration
builder.Services.ConfigureApplicationCookie(cookie =>
{
    cookie.LoginPath = new PathString("/Home/Login");
    //cookie.AccessDeniedPath = new PathString("/Home/Denied");
    cookie.Cookie = new CookieBuilder { Name = "HotCatCookie" };
    cookie.SlidingExpiration = true; //süresi olması lazım
    cookie.ExpireTimeSpan = TimeSpan.FromMinutes(1); //1 dakika sonra kaldırsın
});
 
 */