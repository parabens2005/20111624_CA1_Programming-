namespace HospitalStaffManagement;

// Common state and behaviour for all hospital staff.
public abstract class Staff
{
    public string Name { get; private set; }
    public string StaffId { get; private set; }
    public string Department { get; private set; }

    protected Staff(string name, string staffId, string department)
    {
        Name = RequiredText(name, nameof(name));
        StaffId = RequiredText(staffId, nameof(staffId));
        Department = RequiredText(department, nameof(department));
    }

    // Derived classes reuse this validation without exposing it publicly.
    protected static string RequiredText(string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("A value is required.", parameterName);
        }

        return value.Trim();
    }

    public virtual string GetDetails()
    {
        return $"ID: {StaffId} | Name: {Name} | Department: {Department}";
    }

    public abstract string PerformDuties();
}
