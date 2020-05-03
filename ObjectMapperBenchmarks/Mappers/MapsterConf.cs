using System.Collections.Generic;
using Mapster;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class MapsterConf : IMapper
    {
        public IEnumerable<UniversityDto> Map(IEnumerable<University> source)
        {
            return source.Adapt<IEnumerable<UniversityDto>>();
        }

        public List<UniversityDto> Map(List<University> source)
        {
            return source.Adapt<List<UniversityDto>>();
        }
    }
}