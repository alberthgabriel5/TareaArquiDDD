using NCapasDDD.Infraestructura.Datos.Persistencia.Core;
using NCapasDDD.Infraestructura.Datos.Persistencia.Repositorios;
using NCapasDDD.Dominio.Contratos;
using NCapasDDD.Dominio.Core;


namespace NCapasDDD.Infraestructura.Datos.Persistencia.Implementacion
{
    public class CasaRepositorio : RepositorioBase<NCapasDDD.Dominio.Core.Casa>, ICasaRepositorio
    {
        public CasaRepositorio(IContextoUnidadDeTrabajo unidadDeTrabajo) : base(unidadDeTrabajo)
        {

        }
    }
    }
  
