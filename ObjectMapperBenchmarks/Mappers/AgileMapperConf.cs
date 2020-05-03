using System.Collections.Generic;
using AgileObjects.AgileMapper;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class AgileMapperConf : IMapper
    {
        public IEnumerable<UniversityDto> Map(IEnumerable<University> source)
        {
            return Mapper.Map(source).ToANew<IEnumerable<UniversityDto>>();
        }

        public List<UniversityDto> Map(List<University> source)
        {
            return Mapper.Map(source).ToANew<List<UniversityDto>>();
        }
    }
}