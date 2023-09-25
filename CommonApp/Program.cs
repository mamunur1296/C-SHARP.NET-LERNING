using StudentLibrary;
using TeachersLibrary;
class Program
{
    static void Main()
    {
        // Use the Student class from StudentLibrary
        Student student = new Student
        {
            Name = "John Doe",
            Age = 20
        };

        // Use the Teacher class from TeachersLibrary
        Teacher teacher = new Teacher
        {
            Name = "Mrs. Smith",
            Subject = "Math"
        };

        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}");
        Console.WriteLine($"Teacher: {teacher.Name}, Subject: {teacher.Subject}");
    }
}