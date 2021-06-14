using BPT.Test.JDPS.Core.DTOs;
using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Infraestructure.Mapping;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subjectService"></param>
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        /// <summary>
        /// Add a new subject
        /// </summary>
        /// <param name="subjectDto"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpPost]
        public async Task<IActionResult> AddSubject(SubjectDto subjectDto)
        {
            var subject = SubjectMapper.Map(subjectDto);

            await _subjectService.InsertSubject(subject);

            return Ok("Subject created successfully");
        }

        /// <summary>
        /// Update a subject
        /// </summary>
        /// <param name="subjectDto"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpPut]
        public async Task<IActionResult> UpdateSubject(SubjectDto subjectDto)
        {
            var subject = SubjectMapper.Map(subjectDto);
            await _subjectService.UpdateSubject(subject);

            return Ok("Subject updated successfully");
        }

        /// <summary>
        /// Retrieve all subjects
        /// </summary>
        /// <returns></returns>
        /// [ProducesResponseType(400)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            var subjects = await _subjectService.GetSubjects();
            var subjectsDto = SubjectMapper.Map(subjects);

            return Ok(subjectsDto);
        }

        /// <summary>
        /// Retrieve a specific subject
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubject(int id)
        {
            var subject = await _subjectService.GetSubject(id);
            var subjectDto = SubjectMapper.Map(subject);


            return Ok(subjectDto);
        }

        /// <summary>
        /// Delete a subject
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            await _subjectService.DeleteSubject(id);

            return Ok("Subject deleted successfully");
        }
    }
}
