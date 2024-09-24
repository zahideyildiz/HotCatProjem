using HotCat.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HotCat.IOC.DependencyResolvers
{
    public static class ContextService
    {
        //doğrudan çağıralım diye static olacak
        //Metot parametresinde bulunan services parametresi ilgili metodu hangi katmanda kullanacaksak o katmanın servisi haline bürünmesi için tanımladık.

        public static IServiceCollection AddHotCatDb(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider(); //Sağlayıcı oluşturduk. Bu sağlacının amacı ise IServiceCollection'da bulunan bir takım servisleri bu metot içerisinden ulaşılabilmesidir.

            var configuration = provider.GetService<IConfiguration>(); //Appsettings gibi sabit değerlere ulaşabildiğimiz alanlara bu metot tarafından erişimi sağlamak için

            services.AddDbContext<HotCatContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("HotCatCafe.MVC")));

            return services;
        }
    }
}
