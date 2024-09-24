using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.BLL.Repositories.Concretes;
using HotCat.BLL.Repositories.Concretes.BaseConcrete;
using Microsoft.Extensions.DependencyInjection;

namespace HotCat.IOC.DependencyResolvers
{
    public static class RepositoryServices
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}

/*
 
//Repository Services

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

//Entity Services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

 */
