namespace HospitalStaffManagement.Tests;

[TestClass]
public sealed class StaffManagerTests
{
    [TestMethod]
    [DataRow("D001")]
    [DataRow("N001")]
    [DataRow("A001")]
    public void SearchStaff_ExistingId_ReturnsTrue(string staffId)
    {
        StaffManager manager = CreateManagerWithAllStaff();

        bool found = manager.SearchStaff(staffId);

        Assert.IsTrue(found);
    }

    [TestMethod]
    public void SearchStaff_UnknownId_ReturnsFalse()
    {
        StaffManager manager = CreateManagerWithAllStaff();

        bool found = manager.SearchStaff("D999");

        Assert.IsFalse(found);
    }

    [TestMethod]
    public void SearchStaff_EmptyCollection_ReturnsFalse()
    {
        StaffManager manager = new StaffManager();

        bool found = manager.SearchStaff("D001");

        Assert.IsFalse(found);
    }

    [TestMethod]
    [DataRow("d001")]
    [DataRow("  D001  ")]
    public void SearchStaff_CaseOrSurroundingWhitespace_ReturnsTrue(string staffId)
    {
        StaffManager manager = CreateManagerWithAllStaff();

        bool found = manager.SearchStaff(staffId);

        Assert.IsTrue(found);
    }

    [TestMethod]
    [DataRow(null)]
    [DataRow("")]
    [DataRow("   ")]
    public void SearchStaff_NullOrBlankId_ReturnsFalse(string? staffId)
    {
        StaffManager manager = CreateManagerWithAllStaff();

        bool found = manager.SearchStaff(staffId);

        Assert.IsFalse(found);
    }

    private static StaffManager CreateManagerWithAllStaff()
    {
        StaffManager manager = new StaffManager();
        manager.AddStaff(new Doctor("Aisha Khan", "D001", "Cardiology", "Cardiology"));
        manager.AddStaff(new Nurse("Liam Murphy", "N001", "Emergency", "Day"));
        manager.AddStaff(new AdministrativeStaff("Emma Walsh", "A001", "Reception", "Receptionist"));
        return manager;
    }
}
