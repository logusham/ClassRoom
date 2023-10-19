using ClassRoom.Module.Entity;

namespace ClassRoom.Repository
{
    public interface IStudentRepo
    {
        public Student GetStudent(int Id);
        public List<Student> GetStudents();
        public void DeleteStudent(int Id);
        public void AddStudent(Student student);
        public void UpdateStudent(Student obj);
    }
}
