using BPT.Test.JDPS.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Interfaces
{
    public interface IStudentService
    {
        Task<StudentEntity> GetStudent(int id);

        Task<IEnumerable<StudentEntity>> GetStudents();

        Task InsertStudent(StudentEntity student);

        Task<bool> UpdateStudent(StudentEntity student);

        Task<bool> DeleteStudent(int id);
    }
}
