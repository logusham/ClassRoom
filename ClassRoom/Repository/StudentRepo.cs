using ClassRoom.Module.Entity;
using ClassRoom.Repository.DataAccessLayer;
using Microsoft.EntityFrameworkCore.Storage;

namespace ClassRoom.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDb _db;

        public StudentRepo(ApplicationDb db) { 
        _db = db;
        }

        public Student GetStudent(int Id)
        {
            return _db.Students.FirstOrDefault(x => x.Id == Id);
        }

        public List<Student> GetStudents()
        {
            List<Student> students = _db.Students.ToList();
            return students;
        }
        public void DeleteStudent(int Id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.Id == Id);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
        }

        public void AddStudent(Student student) 
        {
            if (student != null)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
            }
        }

        public void UpdateStudent(Student obj) {

            Student student = _db.Students.FirstOrDefault(x => x.Id == obj.Id);
            if (student != null)
            {
                student.Name = obj.Name;
                student.Age = obj.Age;
                _db.Students.Update(student);
                _db.SaveChanges();
            }
        }

    }
}
