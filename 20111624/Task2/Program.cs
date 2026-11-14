namespace StudentRecords;

internal class Program
{
    private static void Main()
    {
        // Student ID is the key; the complete student record is the value.
        Dictionary<string, Student> students = StudentData.CreateRecords();

        Console.WriteLine("========================================");
        Console.WriteLine("STUDENT RECORDS");
        Console.WriteLine("========================================");
        Console.WriteLine($"Student records stored: {students.Count}");

        while (true)
        {
            Console.Write("\nEnter student ID (or 0 to exit): ");
            string? input = Console.ReadLine();

            if (input is null)
            {
                return;
            }

            string studentId = input.Trim();
            if (studentId == "0")
            {
                Console.WriteLine("Goodbye.");
                return;
            }

            if (studentId.Length == 0)
            {
                Console.WriteLine("Student ID cannot be blank.");
                continue;
            }

            // TryGetValue retrieves the record safely, including when an ID is absent.
            if (students.TryGetValue(studentId, out Student? student))
            {
                DisplayStudent(student);
            }
            else
            {
                Console.WriteLine($"Student not found: {studentId}");
            }
        }
    }

    private static void DisplayStudent(Student student)
    {
        Console.WriteLine($"Student ID: {student.StudentId}");
        Console.WriteLine($"Student Name: {student.Name}");
        Console.WriteLine($"{"Module",-25}{"Marks",-8}Grade");
        Console.WriteLine(new string('-', 40));

        foreach (ModuleResult result in student.Modules)
        {
            Console.WriteLine($"{result.ModuleName,-25}{result.Mark,-8}{result.Grade}");
        }
    }
}
