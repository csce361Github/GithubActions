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
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Subtract("5", "2"));
		Assert.AreEqual(5, Program.Subtract("7", "2"));
		Assert.AreEqual(12, Program.Subtract("14", "0"));
	}

}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Multiply("3", "1"));
		Assert.AreEqual(0, Program.Multiply("0", "2"));
		Assert.AreEqual(12, Program.Multiply("14", "0"));
	}

}
[TestClass]
public class Division
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(12, Program.Divide("14", "0"));
	}

}

[TestClass]
public class Power
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(4, Program.Power("2", "2"));
		Assert.AreEqual(49, Program.Power("7", "2"));
		Assert.AreEqual(12, Program.Power("14", "0"));
	}

}