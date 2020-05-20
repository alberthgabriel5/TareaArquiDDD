using NCapasDDD.Infraestructura.Datos.Persistencia.Core;
using NCapasDDD.Dominio.Contratos;
using System.ComponentModel.Composition;
using NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC;

namespace NCapasDDD.Infraestructura.Datos.Persistencia.Implementacion
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IRegisterModules register)
        {
            register.RegisterTyper<IContextoUnidadDeTrabajo, ContextoPrincipal>();
            register.RegisterTyper<ICasaRepositorio, CasaRepositorio>();

        }
    }
}
