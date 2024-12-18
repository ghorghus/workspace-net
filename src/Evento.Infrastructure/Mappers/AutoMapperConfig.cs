﻿using AutoMapper;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;
using.System.Linq;

namespace Evento.Infrastructure.Mappers
{

    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Evemt, EvemtDto>()
                    .ForMember(x =>TicketsCount, m => m.MapFrom(p => p.Tickets.Count()));
            });
            .CreateMapper();
    }
}