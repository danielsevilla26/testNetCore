using BPT.Test.JDPS.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Interfaces
{
    public interface ISubjectService
    {
        Task<SubjectEntity> GetSubject(int id);

        Task<IEnumerable<SubjectEntity>> GetSubjects();

        Task InsertSubject(SubjectEntity Subject);

        Task<bool> UpdateSubject(SubjectEntity Subject);

        Task<bool> DeleteSubject(int id);
    }
}
