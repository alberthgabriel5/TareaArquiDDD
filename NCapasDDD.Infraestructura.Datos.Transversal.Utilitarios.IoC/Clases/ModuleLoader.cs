using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC
{
    /// <Sumary>
    /// Carga los módulos decorados con el Export y que implementan el IModule
    /// <Sumary>
    public static class ModuleLoader
    {
        /// <Sumary>
        /// Realiza la carga del contenedor de unitu enviado desde el bootstrapper
        /// <Sumary>
        /// <param name= "Container">Contenedor de Unity</param>
        /// <param name= "path">Ruta de la cual se obtendran las dll</param>
        /// <param name= "pattern">Patron para buscar las componentes a cargar</param>
        public static void LoadContainer(IUnityContainer container, string path, string pattern)
        {
            var directoryCatalog = new DirectoryCatalog(path, pattern);
            var importDefinition = BuildImportDefinition();
            try
            {
                using (var aggregateCatalog = new AggregateCatalog())
                {
                    aggregateCatalog.Catalogs.Add(directoryCatalog);

                    using (var compositionContainer = new CompositionContainer(aggregateCatalog))
                    {
                        IEnumerable<Export> exports = compositionContainer.GetExports(importDefinition);
                        IEnumerable<IModule> modules = exports.Select(export => export.Value as IModule).Where(m => m != null);

                        var register = new RegisterModules(container);
                        foreach (IModule module in modules)
                        {
                            module.Initialize(register);
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException typeLoadExeption)
            {
                var builder = new StringBuilder();
                foreach (Exception loaderException in typeLoadExeption.LoaderExceptions)
                {
                    builder.AppendFormat("{0}\n", loaderException.Message);
                }
                throw new TypeLoadException(builder.ToString(), typeLoadExeption);
            }
        }

        

        /// <Sumary>
        /// Construye la definicion del tipo importado
        /// <Sumary>
        /// <returns>Definicion generada</returns>

        private static ImportDefinition BuildImportDefinition()
        {
            return new ImportDefinition(def => true, typeof(IModule).FullName, ImportCardinality.ZeroOrMore, false, false);
        }
    }
}
