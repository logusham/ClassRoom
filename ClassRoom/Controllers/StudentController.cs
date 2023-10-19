using ClassRoom.Module.Entity;
using ClassRoom.Repository;
using ClassRoom.Repository.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace ClassRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _repo;

        public StudentController(IStudentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get(int Id)
        {
            var result = _repo.GetStudent(Id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            var result = _repo.GetStudents();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _repo.AddStudent(student);
            return Ok("Create Successfuley");
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            _repo.UpdateStudent(student);
            return Ok("Update Successfuley");
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _repo.DeleteStudent(Id);
            return Ok("Delete Successfuley");
        }
    }
}
