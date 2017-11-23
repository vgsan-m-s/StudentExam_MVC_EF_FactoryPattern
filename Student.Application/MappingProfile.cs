using AutoMapper;
using Student.Application.Dto;
using Student.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
        }
    }

    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<StudentInfo, StudentInfoDto>()
                .ReverseMap();
        }
    }
}
