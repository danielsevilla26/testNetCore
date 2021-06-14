using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Infraestructure.Data;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestJDPSDatabaseContext _testJDPSDatabaseContext;

        private readonly IRepository<StudentEntity> _studentRepository;

        private readonly IRepository<SubjectEntity> _subjectRepository;

        public UnitOfWork(TestJDPSDatabaseContext context)
        {
            _testJDPSDatabaseContext = context;
        }

        public IRepository<StudentEntity> StudentRepository => _studentRepository ?? new BaseRepository<StudentEntity>(_testJDPSDatabaseContext);

        public IRepository<SubjectEntity> SubjectRepository => _subjectRepository ?? new BaseRepository<SubjectEntity>(_testJDPSDatabaseContext);

        public void Dispose()
        {
            if(_testJDPSDatabaseContext != null)
            {
                _testJDPSDatabaseContext.Dispose();
            }
        }

        public void SaveChanges()
        {
            if(_testJDPSDatabaseContext != null)
            {
                _testJDPSDatabaseContext.SaveChanges();
            }
        }

        public async Task SaveChangesAsync()
        {
            if(_testJDPSDatabaseContext != null)
            {
                await _testJDPSDatabaseContext.SaveChangesAsync();
            }
        }

    }
}
