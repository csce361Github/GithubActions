namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
	[TestMethod]
	public void Add_Empty_Rometh()
	{
		Assert.ThrowsException<ArgumentException>(() => Program.Add("1", ""));
		Assert.ThrowsException<ArgumentException>(() => Program.Add("", "1"));
		Assert.ThrowsException<ArgumentException>(() => Program.Add("", ""));
    }

	[TestMethod]
	public void Power_Valid_Rometh()
	{
		Assert.AreEqual(1, Program.Power("1", "0"));
		Assert.AreEqual(2, Program.Power("2", "1"));
		Assert.AreEqual(4, Program.Power("2", "2"));
		Assert.AreEqual(8, Program.Power("2", "3"));
    }
	[TestMethod]
	public void Power_Invalid_Rometh()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

}
