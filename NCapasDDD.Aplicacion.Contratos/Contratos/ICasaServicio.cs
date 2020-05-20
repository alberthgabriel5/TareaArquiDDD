using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCapasDDD.Aplicacion.Core;

namespace NCapasDDD.Aplicacion.Contratos
{
    public interface ICasaServicio : IDisposable
    {
        
        CasaDTO Obtener(int id);//Select por id
        IEnumerable<CasaDTO> ObtenerTodas();
        IEnumerable<CasaDTO> BuscarPorCalle(string pCalle);
        IEnumerable<CasaDTO> BuscarPorNumeroBaños(int pNumeroBaños);
        CasaDTO BuscarUnoPorCalle(string pcalle);
        bool Agregar(CasaDTO entidad);
        bool Eliminar(CasaDTO entidad);
    }
}
