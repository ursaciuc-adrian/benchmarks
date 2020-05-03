using System.Collections.Generic;

namespace ObjectMapperBenchmarks.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Grade> Grades { get; set; }
    }
}