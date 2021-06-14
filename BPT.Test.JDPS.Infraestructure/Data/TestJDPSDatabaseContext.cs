using BPT.Test.JDPS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BPT.Test.JDPS.Infraestructure.Data
{
    public class TestJDPSDatabaseContext : DbContext
    {
        public TestJDPSDatabaseContext() { }

        public TestJDPSDatabaseContext(DbContextOptions<TestJDPSDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentEntity> Student { get; set; }

        public virtual DbSet<SubjectEntity> Subject { get; set; }

        public virtual DbSet<StudentToSubjectEntity> StudentToSubject { get; set; }

    }
}
