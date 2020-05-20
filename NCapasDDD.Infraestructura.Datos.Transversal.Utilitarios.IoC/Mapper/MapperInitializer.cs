using AutoMapper;
using NCapasDDD.Aplicacion.Core;


namespace NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC
{
    public sealed class MapperInitializer
    {
        public static void ConfigurarMapeos()
        {
            Mapper.Initialize(map =>
            {
                map.AddProfile<MapperProfile>();
            });
        }
    }
}
