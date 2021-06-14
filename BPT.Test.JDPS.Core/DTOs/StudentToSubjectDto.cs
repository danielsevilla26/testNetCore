using BPT.Test.JDPS.Core.Entities;

namespace BPT.Test.JDPS.Core.DTOs
{
    class StudentToSubjectDto : BaseEntity
    {
        public int SubjectId { get; set; }

        public int StudentId { get; set; }
    }
}
