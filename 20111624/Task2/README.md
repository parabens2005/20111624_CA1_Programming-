# Task 2 Student Records

Student ID: **20111624**

This separate C# console project stores exactly 20 student records in a `Dictionary<string, Student>`. Enter a student ID to display the student's name, module marks and grades.

## Run in VS Code

Open the Task2 folder in VS Code, select **Terminal > New Terminal**, then run:

```powershell
dotnet run
```

The project requires the .NET 10 SDK. IDs range from **20001010 to 20001029**. Try **20001010** for the Charles Severance example, **20001029** for the last record, or **20001030** for a missing ID. Enter **0** to exit. Surrounding spaces are removed from input; blank input receives a validation message.

## Data and lookup

- `StudentData.cs` creates the 20 records, using each student's ID as its dictionary key.
- `Student.cs` stores the student ID, name and module results.
- `ModuleResult.cs` stores a module name, mark and grade.
- `Program.cs` reads an ID, uses `TryGetValue()` and displays the matching record or a not-found message.

Record 20001010 reproduces the assignment example. The other 19 records are fictional. The three named modules from the brief are populated. Its fourth and fifth module columns have no names or results, so no extra subjects are invented. Grades are stored explicitly with marks; a grade-calculation scale is not specified in Task 2. Records are held in memory.

## Evidence and report

`Evidence` contains original console inputs, stdout, build output and a verification summary. Checks cover all 20 records and input handling. `Screenshots` contains browser screenshots displaying exact captured stdout excerpts, rather than native terminal captures.

The report is `../Task2_Report.pdf`. A final combined report for all tasks must remain within the assignment's overall 700-word limit and include the official Electronic Assignment Cover Sheet.

Repository: https://github.com/parabens2005/20111624_CA1_Programming-

## Resources and assistance

1. Assignment brief **B9CY108 - CA_ONE_30% (2).pdf**, page 5, Task 2. Used for the dictionary requirement, sample student, module names, marks and grade labels.
2. Microsoft Learn, **Dictionary<TKey,TValue> Class**, https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0 (accessed 14 November 2026). Used for keyed storage of student records.
3. Microsoft Learn, **Dictionary<TKey,TValue>.TryGetValue(TKey, TValue) Method**, https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.trygetvalue?view=net-10.0 (accessed 14 November 2026). Used for safe retrieval and missing-ID handling.
4. **OpenAI Codex assistance, this assignment chat, 14 November 2026.** Generated the Task 2 C# implementation, verification helper, report and evidence preparation. Built and verified the project locally. The verification helper is outside the submission folder; Task 2 application code is entirely C#.
