using System.Xml.Serialization;

namespace proekti.Modules
{
    public class Student
    {
        public int Id { get; set; }


        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int RollNumber { get; set; }

        public char Grade { get; set; }

        public Student() { }
        public Student(string name, string lastName, int rollNumber, char grade)
        {
            Name = name;
            LastName = lastName;
            RollNumber = rollNumber;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}, LastName: {LastName}, RollNumber: {RollNumber}, Grade: {Grade}";
        }
    }
}

