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
	public void Subtract_Valid_Timothy()
	{
		Assert.AreEqual(1, Program.Subtract("2", "1"));
		Assert.AreEqual(2, Program.Subtract("4", "2"));
		Assert.AreEqual(4, Program.Subtract("8", "4"));
	}

	[TestMethod]
	public void Subtract_Invalid_Timothy()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("!", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("2", "!"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("!", "2"));
	}

	[TestMethod]
	public void Subtract_Null_Timothy()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("2", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Timothy()
	{
		Assert.AreEqual(16, Program.Multiply("2", "3"));
		Assert.AreEqual(20, Program.Multiply("4", "5"));
		Assert.AreEqual(84, Program.Multiply("12", "7"));
	}

	[TestMethod]
	public void Multiply_Invalid_Timothy()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("@", "3"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("9", "*"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("&", "10"));
	}

	[TestMethod]
	public void Multiply_Null_Timothy()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("12", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "12"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Timothy()
	{
		Assert.AreEqual(4, Program.Divide("12", "3"));
		Assert.AreEqual(3, Program.Divide("9", "3"));
		Assert.AreEqual(6, Program.Divide("12", "1"));
	}

	[TestMethod]
	public void Divide_Invalid_Timothy()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("@", "3")); 
		Assert.ThrowsException<FormatException>(() => Program.Divide("9", "9")); //failure
		Assert.ThrowsException<FormatException>(() => Program.Divide("10", "!"));
	}

	[TestMethod]
	public void Divide_Null_Timothy()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("8", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "8"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Timothy()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(49, Program.Power("7", "2"));
		Assert.AreEqual(256, Program.Power("4", "4"));
	}

	[TestMethod]
	public void Power_Invalid_Timothy()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("7", "6")); 
		Assert.ThrowsException<FormatException>(() => Program.Power("8", "%"));
		Assert.ThrowsException<FormatException>(() => Program.Power("-", "^"));
	}

	[TestMethod]
	public void Power_Null_Timothy()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("21", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "21"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}