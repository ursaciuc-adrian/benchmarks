using System.Collections.Generic;

namespace ObjectMapperBenchmarks.Dtos
{
    public class UniversityDto
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public List<StudentDto> Students { get; set; }
    }
}