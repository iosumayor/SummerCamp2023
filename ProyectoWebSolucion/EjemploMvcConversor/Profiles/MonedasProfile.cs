using ApiJsonBiblioteca;
using AutoMapper;
using EjemploMvcConversor.Models;
namespace EjemploMvcConversor.Profiles
    {
        public class MonedasProfile : Profile
        {

            public MonedasProfile()
            {
                CreateMap<MonedaJson, Moneda>();
            }
        }
    }

