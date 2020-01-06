using CurrencyView.Repositories;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace CurrencyView
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<ICurrencyRepository, CurrencyRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}