﻿using AutoMapper;
using ArquitecturaMicroservicio.Dto;
using ArquitecturaMicroservicio.Entities;

namespace ArquitecturaMicroservicio.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Persona, PersonaDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>();

            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Cliente, ClienteDto>();

            CreateMap<Cuenta, CuentaDto>().ReverseMap();
            CreateMap<Cuenta, CuentaDto>();

            CreateMap<Movimiento, MovimientoDto>().ReverseMap();
            CreateMap<Movimiento, MovimientoDto>();

            CreateMap<Persona, UsuarioDto>().ReverseMap();
            CreateMap<Persona, UsuarioDto>();

            CreateMap<Cliente, UsuarioDto>().ReverseMap();
            CreateMap<Cliente, UsuarioDto>();

        }

        
    }
}
