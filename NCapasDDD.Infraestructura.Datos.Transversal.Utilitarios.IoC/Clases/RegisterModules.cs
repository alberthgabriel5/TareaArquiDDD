using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC
{
    internal class RegisterModules: IRegisterModules
    {
        private readonly IUnityContainer _contenedor;
        public RegisterModules(IUnityContainer contenedor)
        {
            _contenedor = contenedor;
        }
        public void RegisterTyper<TFrom, TTo>(bool withIterception = false) where TTo : TFrom
        {
            if (!withIterception)
            {
                _contenedor.RegisterType<TFrom, TTo>();
            }
        }
        public void RegisterTypeWithLifeTime<TFrom, TTo>(bool withIterception = false) where TTo : TFrom
        {
            _contenedor.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }
    }
}
