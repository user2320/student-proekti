using proekti.ContractsFolder;
using proekti.Modules;
using proekti.Services;
using student_proekti.Data;
using System.Reflection.Metadata.Ecma335;

StudentService studentServices = new StudentService();

while (true)
{
    Console.WriteLine("1 - To create a student");
    Console.WriteLine("2 - To view all students"); // filtering, get by id
    Console.WriteLine("3 - To update a student");
    Console.WriteLine("4 - To delete a student");
    Console.WriteLine("5 - To exit");

    string userInput = Console.ReadLine() ?? string.Empty;

    Console.Clear();
    switch (userInput)
    {
        case "1":
            var student = GetStudentDetailsFromUser();
            studentServices.Create(student);
            break;
        case "2":
            // Handle view all students logic
            var result = studentServices.ReadAll();
            foreach (var m in result)
            {
                Console.WriteLine($"Name: {m.Name}, LastName: {m.LastName}");
            }
            break;
        case "3":
            // Handle update student logic
            break;
        case "4":
            Console.WriteLine("enter student id:");
            int id = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
            bool isDeleted = studentServices.DeleteById(id);
            if(isDeleted)
            {
                Console.WriteLine("the object was successfuly deleted.");
            }
            else
            {
                Console.WriteLine("failed to delete");
            }

                break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

static Student GetStudentDetailsFromUser()
{
    Console.WriteLine("Enter student's name:");
    string name = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Enter student's last name:");
    string lastname = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Enter student's roll number:");
    int rollnumber = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
    Console.WriteLine("Enter student's grade:");
    char grade = char.TryParse(Console.ReadLine(), out char g) ? g : 'f';

    return new Student
    {
        Name = name,
        LastName = lastname,
        RollNumber = rollnumber,
        Grade = grade,
    };
}
