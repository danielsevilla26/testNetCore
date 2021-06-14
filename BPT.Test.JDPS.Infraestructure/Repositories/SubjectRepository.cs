using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Infraestructure.Data;

namespace BPT.Test.JDPS.Infraestructure.Repositories
{
    public class SubjectRepository : BaseRepository<SubjectEntity>, IRepository<SubjectEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public SubjectRepository(TestJDPSDatabaseContext context) : base(context) { }
    }
}
