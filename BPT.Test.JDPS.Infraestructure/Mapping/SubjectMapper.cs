using BPT.Test.JDPS.Core.DTOs;
using BPT.Test.JDPS.Core.Entities;
using System.Collections.Generic;

namespace BPT.Test.JDPS.Infraestructure.Mapping
{
    public class SubjectMapper
    {
        public static SubjectEntity Map(SubjectDto subjectDto)
        {
            return new SubjectEntity
            {
                Id = subjectDto.Id,
                Name = subjectDto.Name
            };
        }

        public static SubjectDto Map(SubjectEntity subject)
        {
            return new SubjectDto
            {
                Id = subject.Id,
                Name = subject.Name
            };
        }

        public static IEnumerable<SubjectDto> Map(IEnumerable<SubjectEntity> subjects)
        {
            List<SubjectDto> subjectsDto = new List<SubjectDto>();

            foreach (SubjectEntity subjectEntity in subjects)
            {
                SubjectDto subject = new SubjectDto
                {
                    Id = subjectEntity.Id,
                    Name = subjectEntity.Name
                };
                subjectsDto.Add(subject);
            }

            return subjectsDto;
        }
    }
}
