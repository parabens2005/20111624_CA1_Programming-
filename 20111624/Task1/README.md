# Task 1 Hospital Staff Management

Student ID: **20111624**

This C# console application implements only the Task 1 staff management menu. Data is stored in memory for the current run.

## Run

Install the .NET 10 SDK. From this Task1 folder:

```powershell
dotnet run --project HospitalStaffManagement/HospitalStaffManagement.csproj
```

## Unit tests

```powershell
dotnet test HospitalStaffManagement.sln
```

The first test run restores MSTest 4.0.2 from NuGet and requires internet access. There are 10 test cases for `SearchStaff()`: existing IDs for all three types; unknown ID; empty collection; lowercase; surrounding whitespace; null; empty; and whitespace-only input.

## Design

- `Staff`: abstract base class with common properties, a protected constructor, shared validation, virtual `GetDetails()` and abstract `PerformDuties()`.
- `Doctor`, `Nurse`, `AdministrativeStaff`: derived classes with a specific property and overridden methods.
- `StaffManager`: private `List<Staff>`, duplicate ID protection, read-only access for display and Boolean `SearchStaff()`.
- `Program`: the six required menu choices and required-field validation.

Search uses staff ID and returns `true` when found, otherwise `false`. It ignores casing and surrounding whitespace. Staff IDs are unique across all types. Selecting Display All Staff calls each object's overridden details and duty methods through a `Staff` reference.

## Evidence and report

`Screenshots` contains screenshots of captured output from real application and test runs. The screenshots display exact stdout excerpts in a browser for readability; they are not native terminal captures. `Evidence` contains the original input, stdout and MSTest TRX result. Redirected stdin is not echoed in stdout.

The report is `../Task1_Report.pdf`. The official Electronic Assignment Cover Sheet from page 9 of the assignment must be supplied and attached before submission. The eventual combined report for all tasks must remain within 700 words.

Repository: https://github.com/parabens2005/20111624_CA1_Programming-

## Resources and external help

1. Microsoft Learn, **Object-oriented programming - inheritance**, https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance (accessed 13 November 2026). Used for abstract base classes, inheritance and overridden methods.
2. Microsoft Learn, **List<T>.Exists(Predicate<T>) Method**, https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.exists?view=net-10.0 (accessed 13 November 2026). Used for the Boolean existence search through the staff list.
3. Microsoft Learn, **Get started with C# and MSTest**, https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest (accessed 13 November 2026). Used for the separate test project, test attributes, assertions and dotnet test command.
4. **OpenAI Codex assistance, this assignment chat, 13 November 2026.** Generated the C# application, MSTest tests, report and evidence preparation; built and checked the implementation locally. The task prompt supplied in this chat was the specification.
