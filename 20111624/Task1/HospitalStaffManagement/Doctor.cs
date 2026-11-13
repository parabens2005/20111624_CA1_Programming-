namespace HospitalStaffManagement;

public class Doctor : Staff
{
    public string Specialisation { get; private set; }

    public Doctor(string name, string staffId, string department, string specialisation)
        : base(name, staffId, department)
    {
        Specialisation = RequiredText(specialisation, nameof(specialisation));
    }

    public override string GetDetails()
    {
        return $"Doctor | {base.GetDetails()} | Specialisation: {Specialisation}";
    }

    public override string PerformDuties()
    {
        return $"Dr {Name} diagnoses patients and provides {Specialisation} treatment.";
    }
}
