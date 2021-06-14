using BPT.Test.JDPS.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Interfaces
{
    public interface IStudentToSubject
    {
        Task<StudentToSubjectEntity> GetStudentToSubject(int id);

        Task<IEnumerable<StudentToSubjectEntity>> GetStudentsToSubjects();

        Task InsertStudentToSubject(StudentToSubjectEntity studentToSubject);

        Task<bool> DeleteStudentToSubject(int id);
    }
}
