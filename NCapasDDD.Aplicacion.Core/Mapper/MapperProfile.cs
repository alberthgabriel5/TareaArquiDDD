using AutoMapper;
using NCapasDDD.Dominio.Core;

namespace NCapasDDD.Aplicacion.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Casa, CasaDTO>();
            CreateMap<CasaDTO, Casa>();
        }
    }
}
