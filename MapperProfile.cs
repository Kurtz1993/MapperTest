using System;
using AutoMapper;

namespace MapperTest
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<OneModel, AnotherModel>();
        }
    }
}
