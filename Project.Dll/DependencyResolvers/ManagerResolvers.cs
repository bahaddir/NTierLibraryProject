using Microsoft.Extensions.DependencyInjection;
using Project.Bll.Managers.Abstracts;
using Project.Bll.Managers.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<,>)); 
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ITagManager, TagManager>();
            services.AddScoped<IBookTagManager, BookTagManager>();
        }
    }
}
