namespace StudentRecords;

public class ModuleResult
{
    public string ModuleName { get; }
    public int Mark { get; }
    public string Grade { get; }

    public ModuleResult(string moduleName, int mark, string grade)
    {
        ModuleName = moduleName;
        Mark = mark;
        Grade = grade;
    }
}
