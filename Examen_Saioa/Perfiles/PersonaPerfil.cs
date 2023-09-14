using AutoMapper;
using DTOs;
using Entidades_BBDD;
using Helpers;

namespace Perfiles
{
    public class PersonaPerfil :Profile
    {
        public PersonaPerfil()
        {
            CreateMap<Persona, PersonaDTO>()
            .ForMember(dest => dest.Edad, opt =>
                opt.MapFrom(src => src.FechaNacimiento.GetCurrentAge()));

            CreateMap<Persona, PersonaCrearDTO>().ReverseMap();

        }
        
    }
}