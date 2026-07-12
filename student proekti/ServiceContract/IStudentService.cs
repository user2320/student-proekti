using proekti.Modules;

namespace proekti.ContractsFolder
{
    public interface IStudentService
    {
     void Create(Student student);
     Student? GetById(int rollNumber);
     List<Student> ReadAll();
     bool UpdateGrade(int rollNumber, char grade);
     bool DeleteById(int rollNumber);

    }
}
