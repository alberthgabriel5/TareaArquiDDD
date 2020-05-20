using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCapasDDD.Dominio.Core;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace NCapasDDD.Infraestructura.Datos.Persistencia.Core
{
    public class ContextoPrincipal : DbContext, IContextoUnidadDeTrabajo
    {
        public ContextoPrincipal() : base("TareaIngeneriaB21190Entities") { }
        //Atributo
        IDbSet<Casa> _casa;
        //Propiedad
        public IDbSet<Casa> Casas
        {
            get { return _casa ?? (_casa = base.Set<Casa>()); }
        }

        IDbSet<Casa> IContextoUnidadDeTrabajo.Casas => throw new NotImplementedException();

        public new IDbSet<Entidad> Set<Entidad>() where Entidad : class
        {
            return base.Set<Entidad>();
        }
        public void Attach<Entidad>(Entidad item) where Entidad : class
        {
            if (Entry(item).State == EntityState.Detached)
            {
                base.Set<Entidad>().Attach(item);
            }
        }
        public void SetModified<Entidad>(Entidad item) where Entidad : class
        {
            Entry(item).State = EntityState.Modified;

        }



        public int Completar()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
