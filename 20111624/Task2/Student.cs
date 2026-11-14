namespace StudentRecords;

public class Student
{
    public string StudentId { get; }
    public string Name { get; }
    public IReadOnlyList<ModuleResult> Modules { get; }

    public Student(string studentId, string name, List<ModuleResult> modules)
    {
        StudentId = studentId;
        Name = name;
        Modules = modules.AsReadOnly();
    }
}
