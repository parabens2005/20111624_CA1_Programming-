namespace HospitalStaffManagement;

public class StaffManager
{
    // One list stores objects of all three derived staff types.
    private readonly List<Staff> staffMembers = new();

    public void AddStaff(Staff member)
    {
        ArgumentNullException.ThrowIfNull(member);

        if (SearchStaff(member.StaffId))
        {
            throw new ArgumentException("A staff member with this ID already exists.");
        }

        staffMembers.Add(member);
    }

    public IReadOnlyList<Staff> GetAllStaff()
    {
        return staffMembers.AsReadOnly();
    }

    // A Boolean is a binary result: true means found, false means not found.
    public bool SearchStaff(string? staffId)
    {
        if (string.IsNullOrWhiteSpace(staffId))
        {
            return false;
        }

        string searchId = staffId.Trim();
        return staffMembers.Exists(member =>
            string.Equals(member.StaffId, searchId, StringComparison.OrdinalIgnoreCase));
    }
}
