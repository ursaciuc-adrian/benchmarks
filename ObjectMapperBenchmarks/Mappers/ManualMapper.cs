using System.Collections.Generic;
using System.Linq;
using ObjectMapperBenchmarks.Dtos;
using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Mappers
{
    public class ManualMapper : IMapper
    {
        public List<UniversityDto> Map(List<University> source)
        {
            return source.Select(ToDto).ToList();
        }

        public IEnumerable<UniversityDto> MapI(IEnumerable<University> source)
        {
            return source.Select(ToDto);
        }
        
        private static GradeDto ToDto(Grade model)
        {
            return new GradeDto
            {
                Course = model.Course,
                Points = model.Points
            };
        }

        private static StudentDto ToDto(Student model)
        {
            return new StudentDto
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Grades = model.Grades.Select(ToDto).ToList()
            };
        }

        private static UniversityDto ToDto(University model)
        {
            return new UniversityDto
            {
                City = model.City,
                Country = model.Country,
                Name = model.Name,
                Students = model.Students.Select(ToDto).ToList()
            };
        }
    }
}