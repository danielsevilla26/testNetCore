using BPT.Test.JDPS.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<StudentEntity> StudentRepository { get; }

        IRepository<SubjectEntity> SubjectRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
