using System.Collections.Generic;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public interface IMapper
    {
        List<UniversityDto> Map(List<University> source);
    }
}