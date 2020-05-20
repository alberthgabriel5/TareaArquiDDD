using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC;
namespace NCapasDDD.Tarea2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var unityContainer = Bootstrapper.Initialize();
            ModuleLoader.LoadContainer(unityContainer, ".\\bin", "NCapasDDD.Infraestructura.Datos.Persistencia.Implementacion.dll");
            ModuleLoader.LoadContainer(unityContainer, ".\\bin", "NCapasDDD.Aplicacion.Implementacion.dll");
            MapperInitializer.ConfigurarMapeos();
        }
    }
}
