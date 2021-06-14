using BPT.Test.JDPS.Core.DTOs;
using BPT.Test.JDPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JDPS.Infraestructure.Mapping
{
    public class StudentMapper
    {
        public static StudentEntity Map(StudentDto studentDto)
        {
            return new StudentEntity
            {
                Id = studentDto.Id,
                Name = studentDto.Name,
                Birth = studentDto.Birth
            };
        } 

        public static StudentDto Map(StudentEntity student)
        {
            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Birth = student.Birth
            };
        }

        public static IEnumerable<StudentDto> Map(IEnumerable<StudentEntity> students)
        {
            List<StudentDto> studentsDto = new List<StudentDto>();

            foreach(StudentEntity studentEntity in students)
            {
                StudentDto student = new StudentDto
                {
                    Id = studentEntity.Id,
                    Name = studentEntity.Name,
                    Birth = studentEntity.Birth
                };
                studentsDto.Add(student);
            }

            return studentsDto;
        }
    }
}
