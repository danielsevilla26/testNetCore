using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Infraestructure.Data;

namespace BPT.Test.JDPS.Infraestructure.Repositories
{
    public class StudentRepository : BaseRepository<StudentEntity>, IRepository<StudentEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public StudentRepository(TestJDPSDatabaseContext context) : base(context) { }
    }
}
