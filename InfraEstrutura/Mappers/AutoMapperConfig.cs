﻿using AutoMapper;

namespace Amf.PeladaFC.Infraestrutura.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntityToDomainProfile>();
                x.AddProfile<DomainToEntityProfile>();
            });
        }

    }
}
