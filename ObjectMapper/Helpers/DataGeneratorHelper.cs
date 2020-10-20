using System;
using System.Collections.Generic;

using ObjectMapperBenchmarks.Models;

namespace ObjectMapperBenchmarks.Helpers
{
    public static class DataGeneratorHelper
    {
        public static List<University> GenerateData(int noOfUniversities, int noOfStudents, int noOfGrades)
        {
            var universities = new List<University>();

            for (var i = 0; i <= noOfUniversities; i++)
            {
                var university = new University
                {
                    City = $"City_{i}",
                    Country = $"Country_{i}",
                    Name = $"University_{i}",
                    Students = new List<Student>()
                };

                for (var j = 0; j < noOfStudents; j++)
                {
                    var student = new Student
                    {
                        FirstName = $"FirstName_{i}_{j}",
                        LastName = $"LastName{i}_{j}",
                        Grades = new List<Grade>()
                    };

                    university.Students.Add(student);

                    for (var k = 0; k < noOfGrades; k++)
                    {
                        var grade = new Grade
                        {
                            Course = $"Course_{i}_{j}_{k}",
                            Points = new Random().Next(0, 10)
                        };

                        student.Grades.Add(grade);
                    }
                }

                universities.Add(university);
            }

            return universities;
        }
    }
}