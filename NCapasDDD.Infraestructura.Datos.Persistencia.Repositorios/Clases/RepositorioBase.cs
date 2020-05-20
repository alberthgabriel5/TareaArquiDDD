﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCapasDDD.Dominio.Core;
using NCapasDDD.Infraestructura.Datos.Persistencia.Core;
using System.Linq.Expressions;
namespace NCapasDDD.Infraestructura.Datos.Persistencia.Repositorios
{
    public class RepositorioBase<Entidad> : IRepositorioBase<Entidad> where Entidad : class
    {
        readonly IContextoUnidadDeTrabajo _unidadDeTrabajo;
        public IUnidadDeTrabajo UnidadDeTrabajo
        {
            get { return _unidadDeTrabajo; }
        }
        public RepositorioBase(IContextoUnidadDeTrabajo unidadTrabajo)
        {
            _unidadDeTrabajo = unidadTrabajo;
        }

        public Entidad Obtener(int id)
        {
            return _unidadDeTrabajo.Set<Entidad>().Find(id);
        }
        public IEnumerable<Entidad> ObtenerTodas() 
        {
            return _unidadDeTrabajo.Set<Entidad>().ToList();
        }
        public IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>> predicado)
        {
            return _unidadDeTrabajo.Set<Entidad>().ToList();
        }
        public Entidad BuscarSingleOrDefault(Expression<Func<Entidad, bool>> predicado)
        {
            return _unidadDeTrabajo.Set<Entidad>().Single(predicado);
        }

        public void Agregar(Entidad entidad)
        {
            _unidadDeTrabajo.Set<Entidad>().Add(entidad);
        }
        public void Eliminar(Entidad entidad)
        {
            _unidadDeTrabajo.Set<Entidad>().Remove(entidad);
        }
        public void Dispose()
        {
            _unidadDeTrabajo.Dispose();
        }
    }
}
