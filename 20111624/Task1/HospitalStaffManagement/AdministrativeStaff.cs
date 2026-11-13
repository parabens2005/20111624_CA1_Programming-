namespace HospitalStaffManagement;

public class AdministrativeStaff : Staff
{
    public string Role { get; private set; }

    public AdministrativeStaff(string name, string staffId, string department, string role)
        : base(name, staffId, department)
    {
        Role = RequiredText(role, nameof(role));
    }

    public override string GetDetails()
    {
        return $"Administrative Staff | {base.GetDetails()} | Role: {Role}";
    }

    public override string PerformDuties()
    {
        return $"{Name} manages appointments and staff records as {Role}.";
    }
}
