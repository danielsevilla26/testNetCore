namespace BPT.Test.JDPS.Core.Entities
{
    public class StudentToSubjectEntity : BaseEntity
    {
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        public SubjectEntity Subject { get; set; }

        public StudentEntity Student { get; set; }
    }
}
