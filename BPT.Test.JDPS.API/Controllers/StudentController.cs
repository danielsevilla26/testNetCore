using BPT.Test.JDPS.Core.DTOs;
using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Infraestructure.Mapping;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="studentService"></param>
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        /// <summary>
        /// Add a new student
        /// </summary>
        /// <param name="studentDto"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentDto studentDto)
        {
            var student = StudentMapper.Map(studentDto);

            await _studentService.InsertStudent(student);

            return Ok("Student created successfully");
        }

        /// <summary>
        /// Update a student
        /// </summary>
        /// <param name="studentDto"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpPut]
        public async Task<IActionResult> UpdateStudent(StudentDto studentDto)
        {
            var student = StudentMapper.Map(studentDto);
            await _studentService.UpdateStudent(student);

            return Ok("Student updated successfully");
        }

        /// <summary>
        /// Retrieve all students
        /// </summary>
        /// <returns></returns>
        /// [ProducesResponseType(400)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentService.GetStudents();
            var studentsDto = StudentMapper.Map(students);

            return Ok(studentsDto);
        }

        /// <summary>
        /// Retrieve a specific student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await _studentService.GetStudent(id);
            var studentDto = StudentMapper.Map(student);


            return Ok(studentDto);
        }

        /// <summary>
        /// Delete a student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await _studentService.DeleteStudent(id);

            return Ok("Student deleted successfully");
        }
    }
}
