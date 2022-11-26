using DAL.IRepository;
using DAL.Repository;
using Service.IService;
using Service.Service;

namespace layers.common.IoExtention
{
    public static class IoExtentions
    {
        public static IServiceCollection RegisterServices(this WebApplicationBuilder builder) {
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            return builder.Services;
        }
    }
}
