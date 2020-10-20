using System.Collections.Generic;
using Nelibur.ObjectMapper;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class TinyMapperConf : IMapper
    {
        public TinyMapperConf()
        {
            TinyMapper.Bind<List<University>, List<UniversityDto>>();    
        }
        
        public List<UniversityDto> Map(List<University> source)
        {
            return TinyMapper.Map<List<UniversityDto>>(source);
        }
    }
}