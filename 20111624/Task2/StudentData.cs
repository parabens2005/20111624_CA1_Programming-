namespace StudentRecords;

public static class StudentData
{
    public static Dictionary<string, Student> CreateRecords()
    {
        Dictionary<string, Student> students = new();

        // First record reproduces the assignment example. The other 19 are fictional.
        // Each mark is stored with its grade; no grading scale is assumed.
        AddStudent(students, "20001010", "Charles Severance", 70, "B+", 65, "B", 55, "C");
        AddStudent(students, "20001011", "Aisha Khan",       65, "B",  70, "B+", 55, "C");
        AddStudent(students, "20001012", "Liam Murphy",      55, "C",  65, "B",  70, "B+");
        AddStudent(students, "20001013", "Emma Walsh",       70, "B+", 55, "C",  65, "B");
        AddStudent(students, "20001014", "Noah Byrne",       65, "B",  55, "C",  70, "B+");
        AddStudent(students, "20001015", "Sofia Patel",      55, "C",  70, "B+", 65, "B");
        AddStudent(students, "20001016", "Oliver Kelly",     70, "B+", 70, "B+", 65, "B");
        AddStudent(students, "20001017", "Mia Ryan",         65, "B",  65, "B",  70, "B+");
        AddStudent(students, "20001018", "Lucas Silva",      55, "C",  55, "C",  65, "B");
        AddStudent(students, "20001019", "Amelia Wilson",    70, "B+", 65, "B",  70, "B+");
        AddStudent(students, "20001020", "Ethan Brown",      65, "B",  70, "B+", 65, "B");
        AddStudent(students, "20001021", "Isla Martin",      55, "C",  65, "B",  55, "C");
        AddStudent(students, "20001022", "Arjun Shah",       70, "B+", 55, "C",  70, "B+");
        AddStudent(students, "20001023", "Grace Nolan",      65, "B",  55, "C",  65, "B");
        AddStudent(students, "20001024", "Daniel Chen",      55, "C",  70, "B+", 55, "C");
        AddStudent(students, "20001025", "Chloe Evans",      70, "B+", 70, "B+", 70, "B+");
        AddStudent(students, "20001026", "James Clarke",     65, "B",  65, "B",  65, "B");
        AddStudent(students, "20001027", "Priya Rao",        55, "C",  55, "C",  55, "C");
        AddStudent(students, "20001028", "Adam Hassan",      70, "B+", 65, "B",  65, "B");
        AddStudent(students, "20001029", "Ella Doyle",       65, "B",  70, "B+", 70, "B+");

        return students;
    }

    private static void AddStudent(Dictionary<string, Student> students,
        string studentId, string name,
        int programmingMark, string programmingGrade,
        int databasesMark, string databasesGrade,
        int networkingMark, string networkingGrade)
    {
        // These are the three populated modules in the assignment table.
        List<ModuleResult> modules = new()
        {
            new ModuleResult("Advanced Programming", programmingMark, programmingGrade),
            new ModuleResult("Adv. Databases", databasesMark, databasesGrade),
            new ModuleResult("Networking & Security", networkingMark, networkingGrade)
        };

        Student student = new(studentId, name, modules);
        students.Add(student.StudentId, student);
    }
}
