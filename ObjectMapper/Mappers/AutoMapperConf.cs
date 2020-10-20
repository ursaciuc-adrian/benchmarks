using System.Collections.Generic;
using AutoMapper;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class AutoMapperConf : IMapper
    {
        private readonly Mapper _mapper;

        public AutoMapperConf()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Grade, GradeDto>();
                cfg.CreateMap<Student, StudentDto>();
                cfg.CreateMap<University, UniversityDto>();
            });
            
            config.CompileMappings();
            
            _mapper = new Mapper(config);
        }

        public List<UniversityDto> Map(List<University> source)
        {
            return _mapper.Map<List<University>, List<UniversityDto>>(source);
        }
    }
}