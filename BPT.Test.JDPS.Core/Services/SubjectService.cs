using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Core.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public SubjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<SubjectEntity> GetSubject(int id)
        {
            var subject = await _unitOfWork.SubjectRepository.GetById(id);

            if (subject == null)
            {
                throw new Exception("Subject doesn't exist");
            }

            return subject;
        }

        public async Task<IEnumerable<SubjectEntity>> GetSubjects()
        {
            var subjects = _unitOfWork.SubjectRepository.GetAll();
            if (subjects == null)
            {
                throw new Exception("There aren't subjects in DB");
            }

            return subjects;
        }

        public async Task InsertSubject(SubjectEntity subject)
        {
            await _unitOfWork.SubjectRepository.Add(subject);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateSubject(SubjectEntity subject)
        {
            var existingSubject = await _unitOfWork.SubjectRepository.GetById(subject.Id);

            if (existingSubject == null)
            {
                throw new Exception("Subject doesn't exist");
            }

            existingSubject.Name = subject.Name;

            _unitOfWork.SubjectRepository.Update(existingSubject);

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSubject(int id)
        {
            var subject = await GetSubject(id);

            await _unitOfWork.SubjectRepository.Delete(subject);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
