using System.Collections.Generic;
using EmitMapper;
using EmitMapper.MappingConfiguration;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class EmitMapperConf : IMapper
    {
        public List<UniversityDto> Map(List<University> source)
        {
            var mapper = ObjectMapperManager
                .DefaultInstance
                .GetMapper<List<University>, List<UniversityDto>>(new DefaultMapConfig());


            return mapper.Map(source);
        }
    }
}