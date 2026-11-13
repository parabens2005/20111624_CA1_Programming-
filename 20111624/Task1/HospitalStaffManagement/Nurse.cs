namespace HospitalStaffManagement;

public class Nurse : Staff
{
    public string Shift { get; private set; }

    public Nurse(string name, string staffId, string department, string shift)
        : base(name, staffId, department)
    {
        Shift = RequiredText(shift, nameof(shift));
    }

    public override string GetDetails()
    {
        return $"Nurse | {base.GetDetails()} | Shift: {Shift}";
    }

    public override string PerformDuties()
    {
        return $"{Name} monitors patients and administers care during the {Shift} shift.";
    }
}
