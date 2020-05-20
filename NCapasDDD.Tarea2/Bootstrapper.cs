using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;
using NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC;
namespace NCapasDDD.Tarea2
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialize()
        {
            var contenedor = BuilUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(contenedor));
            return contenedor;
        }
    private static IUnityContainer BuilUnityContainer()
        {
            var contenedor = new UnityContainer();
            RegisterTypes(contenedor);
            return contenedor;
        }
        public static void RegisterTypes(IUnityContainer contenedor)
        {
            ModuleLoader.LoadContainer(contenedor, ".\\bin", "NCapasDDD.Aplicacion.*.dll");
            ModuleLoader.LoadContainer(contenedor, ".\\bin", "NCapasDDD.Dominio.*.dll");
            ModuleLoader.LoadContainer(contenedor, ".\\bin", "NCapasDDD.Infraestructura.Datos.Persistencia.*.dll");
        }
    }
}