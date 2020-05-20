using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCapasDDD.Dominio.Core;
namespace NCapasDDD.Infraestructura.Datos.Persistencia.Core
{
    public interface IContextoUnidadDeTrabajo: IUnidadDeTrabajo,IDisposable
    {
        IDbSet<Casa> Casas {get;}
        IDbSet<Entidad> Set<Entidad>() where Entidad : class;

        void Attach<Entidad> (Entidad item ) where Entidad : class;
        void SetModified<Entidad>(Entidad item) where Entidad : class;
    }
}
