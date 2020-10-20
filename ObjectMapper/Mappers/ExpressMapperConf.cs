using System.Collections.Generic;
using ExpressMapper.Extensions;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class ExpressMapperConf : IMapper
    {

        public ExpressMapperConf()
        {
            ExpressMapper.Mapper.Register<University, UniversityDto>();
            
            ExpressMapper.Mapper.Compile();
        }

        public IEnumerable<UniversityDto> Map(IEnumerable<University> source)
        {
            return source.Map<IEnumerable<University>, IEnumerable<UniversityDto>>();
        }

        public List<UniversityDto> Map(List<University> source)
        {
            return source.Map<List<University>, List<UniversityDto>>();
        }
    }
}