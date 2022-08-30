using DIExample.Models;
using DIExample.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DIExample
{
    public static class ExtensionMethods
    {
        public static IServiceCollection AddDI(this IServiceCollection serv,IConfiguration  config)
        {
            //services.AddTransient<IGetEmpInfo, GetEmpEmailInfo>();
            serv.AddTransient(typeof(IGetEmpInfo), typeof(GetEmpEmailInfo));
            //  services.AddTransient<IGetEmpInfo, GetEmpNameInfo>();
            serv.AddScoped<GetEmpAllInfo>();
            serv.Configure<Location>(config.GetSection("Location"));
            serv.AddTransient<WelcomeMessageForMiddleWare>();
            serv.AddTransient<IGetNewGuid,GetNewGuid>();
            return serv;
        }
    }
}
