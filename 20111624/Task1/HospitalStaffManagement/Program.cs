namespace HospitalStaffManagement;

internal class Program
{
    private static void Main()
    {
        StaffManager manager = new();

        while (true)
        {
            DisplayMenu();
            string? choice = Console.ReadLine();

            // End cleanly if input is closed, as well as when 0 is selected.
            if (choice is null)
            {
                return;
            }

            switch (choice.Trim())
            {
                case "1":
                case "2":
                case "3":
                    AddStaff(manager, choice.Trim());
                    break;
                case "4":
                    DisplayAllStaff(manager);
                    break;
                case "5":
                    Console.Write("Enter staff ID to search: ");
                    bool found = manager.SearchStaff(Console.ReadLine());
                    Console.WriteLine(found ? "Staff found (True)." : "Staff not found (False).");
                    break;
                case "0":
                    Console.WriteLine("Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Enter 0, 1, 2, 3, 4 or 5.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("STAFF MANAGEMENT");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Add Doctor");
        Console.WriteLine("2. Add Nurse");
        Console.WriteLine("3. Add Administrative Staff");
        Console.WriteLine("4. Display All Staff");
        Console.WriteLine("5. Search Staff");
        Console.WriteLine("0. Exit");
        Console.WriteLine("========================================");
        Console.Write("Enter your choice: ");
    }

    private static void AddStaff(StaffManager manager, string choice)
    {
        string? name = ReadRequired("Name: ");
        if (name is null) return;

        string? staffId = ReadRequired("Staff ID: ");
        if (staffId is null) return;

        if (manager.SearchStaff(staffId))
        {
            Console.WriteLine("A staff member with this ID already exists.");
            return;
        }

        string? department = ReadRequired("Department: ");
        if (department is null) return;

        Staff member;
        switch (choice)
        {
            case "1":
                string? specialisation = ReadRequired("Specialisation: ");
                if (specialisation is null) return;
                member = new Doctor(name, staffId, department, specialisation);
                break;
            case "2":
                string? shift = ReadRequired("Shift: ");
                if (shift is null) return;
                member = new Nurse(name, staffId, department, shift);
                break;
            default:
                string? role = ReadRequired("Administrative role: ");
                if (role is null) return;
                member = new AdministrativeStaff(name, staffId, department, role);
                break;
        }

        manager.AddStaff(member);
        Console.WriteLine($"Staff member {member.StaffId} added successfully.");
    }

    private static string? ReadRequired(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? value = Console.ReadLine();

            if (value is null)
            {
                return null;
            }

            if (!string.IsNullOrWhiteSpace(value))
            {
                return value.Trim();
            }

            Console.WriteLine("This field cannot be blank.");
        }
    }

    private static void DisplayAllStaff(StaffManager manager)
    {
        IReadOnlyList<Staff> staff = manager.GetAllStaff();

        if (staff.Count == 0)
        {
            Console.WriteLine("No staff have been added.");
            return;
        }

        Console.WriteLine("ALL STAFF");
        foreach (Staff member in staff)
        {
            // Runtime dispatch calls the correct derived class methods.
            Console.WriteLine(member.GetDetails());
            Console.WriteLine($"Duty: {member.PerformDuties()}");
            Console.WriteLine();
        }
    }
}
