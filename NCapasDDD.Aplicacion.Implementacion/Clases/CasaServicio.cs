using System;
using System.Collections.Generic;
using NCapasDDD.Aplicacion.Contratos;
using NCapasDDD.Aplicacion.Core;
using NCapasDDD.Dominio.Contratos;
using NCapasDDD.Dominio.Core;
using AutoMapper;
namespace NCapasDDD.Aplicacion.Implementacion.Clases
{
    public class CasaServicio : ICasaServicio
    {
        #region Atributos
        private ICasaRepositorio _casaRepositorio;
        #endregion

        #region Constructor
        public CasaServicio(ICasaRepositorio pcasaServicio)
        {
            _casaRepositorio = pcasaServicio;
        }
        #endregion

        #region Metodos
        public CasaDTO Obtener(int id)
        {
            var objetoRecuperado = _casaRepositorio.Obtener(id);
            return Mapper.Map<Casa, CasaDTO>(objetoRecuperado);
        }

        public IEnumerable<CasaDTO> ObtenerTodas()
        {
            var lista = _casaRepositorio.ObtenerTodas();
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }


        public IEnumerable<CasaDTO> BuscarPorCalle(string pDireccion)
        {
            var lista = _casaRepositorio.Buscar(x => x.Calle.ToUpper().Equals(pDireccion.ToUpper()));
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }

        public IEnumerable<CasaDTO> BuscarPorNumeroBaños(int pNumeroBaños)
        {
            var lista = _casaRepositorio.Buscar(x => x.NumeroBaños.Equals(pNumeroBaños));
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }

        public CasaDTO BuscarUnoPorCalle(string pCalle)
        {
            var objetoRecuperado = _casaRepositorio.BuscarSingleOrDefault(x => x.Calle.ToUpper().Equals(pCalle.ToUpper()));
            return Mapper.Map<Casa, CasaDTO>(objetoRecuperado);
        }

        public bool Agregar(CasaDTO entidad)
        {
            try
            {
                var _objetoInsertar = new Casa();
                Mapper.Map(entidad, _objetoInsertar);
                _casaRepositorio.Agregar(_objetoInsertar);
                _casaRepositorio.UnidadDeTrabajo.Completar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Eliminar(CasaDTO entidad)
        {
            try
            {
                var _objetoEliminar = new Casa();
                Mapper.Map(entidad, _objetoEliminar);
                _casaRepositorio.Eliminar(_objetoEliminar);
                _casaRepositorio.UnidadDeTrabajo.Completar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Dispose
        ~CasaServicio() { }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_casaRepositorio != null)
                {
                    _casaRepositorio.Dispose();
                    _casaRepositorio = null;
                }
            }
        }

        #endregion

    }
}
