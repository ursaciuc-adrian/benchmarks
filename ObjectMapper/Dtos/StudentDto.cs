using System.Collections.Generic;

namespace ObjectMapperBenchmarks.Dtos
{
    public class StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<GradeDto> Grades { get; set; }
    }
}