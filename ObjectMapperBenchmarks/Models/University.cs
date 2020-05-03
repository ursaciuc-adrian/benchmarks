using System.Collections.Generic;

namespace ObjectMapperBenchmarks.Models
{
    public class University
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public List<Student> Students { get; set; }
    }
}