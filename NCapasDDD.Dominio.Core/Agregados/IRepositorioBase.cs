using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NCapasDDD.Dominio.Core
{
    public interface IRepositorioBase<Entidad>:IDisposable
    {
        IUnidadDeTrabajo UnidadDeTrabajo { get; }
        Entidad Obtener(int id);//Select por id
        IEnumerable<Entidad> ObtenerTodas();
        IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>> predicado);
        Entidad BuscarSingleOrDefault(Expression<Func<Entidad,bool>>predicado);

        void Agregar(Entidad entidad);
        void Eliminar(Entidad entidad);


    }
}
