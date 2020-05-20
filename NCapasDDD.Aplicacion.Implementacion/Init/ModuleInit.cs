using NCapasDDD.Aplicacion.Contratos;
using NCapasDDD.Dominio.Contratos;
using System.ComponentModel.Composition;
using NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC;
using NCapasDDD.Aplicacion.Implementacion.Clases;

namespace NCapasDDD.Aplicacion.Implementacion
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IRegisterModules register)
        {
              register.RegisterType<ICasaServicio, CasaServicio>();

        }
    }
}
