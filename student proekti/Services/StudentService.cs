using proekti.ContractsFolder;
using proekti.Modules;
using student_proekti.Data;
using System.Xml.Serialization;

namespace proekti.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext studentDb;

        public StudentService()
        {
            studentDb = new StudentDbContext();
        }
        public void Create(Student student)
        {
         studentDb.Students.Add(student);
         studentDb.SaveChanges();
        }

        public List<Student> ReadAll()
        {
            return studentDb.Students.ToList();
        }

        public Student? GetById(int id)
        {
            return studentDb.Students.FirstOrDefault(s => s.Id == id);
        }

        public bool UpdateGrade(int rollNumber, char grade)
        {
            var student = GetById(rollNumber);

            if (student == null)
                return false;

            student.Grade = grade;
            studentDb.SaveChanges();
            return true;
        }

        public bool DeleteById(int id)
        {
            var student = GetById(id);

            if (student == null)
                return false;

            studentDb.Students.Remove(student);
            studentDb.SaveChanges();
            return true;
        }

    }
}
