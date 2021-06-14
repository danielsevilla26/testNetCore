using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<StudentEntity> GetStudent(int id)
        {
            var student = await _unitOfWork.StudentRepository.GetById(id);

            if(student == null)
            {
                throw new Exception("Student doesn't exist");
            }

            return student;
        }

        public async Task<IEnumerable<StudentEntity>> GetStudents()
        {
            var students = _unitOfWork.StudentRepository.GetAll();
            if (students == null)
            {
                throw new Exception("There aren't students in DB");
            }

            return students;
        }

        public async Task InsertStudent(StudentEntity student)
        {
            await _unitOfWork.StudentRepository.Add(student);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateStudent(StudentEntity student)
        {
            var existingStudent = await _unitOfWork.StudentRepository.GetById(student.Id);

            if (existingStudent == null)
            {
                throw new Exception("Student doesn't exist");
            }

            existingStudent.Name = student.Name;
            existingStudent.Birth = student.Birth;

            _unitOfWork.StudentRepository.Update(existingStudent);

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var student = await GetStudent(id);

            await _unitOfWork.StudentRepository.Delete(student);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
