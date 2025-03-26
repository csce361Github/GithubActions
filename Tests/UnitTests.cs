namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Ngo()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Ngo()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Ngo()
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
	public void Subtract_Valid_Ngo()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-1, Program.Subtract("2", "3"));
		Assert.AreEqual(0, Program.Subtract("5", "5"));
	}

	[TestMethod]
	public void Subtract_Invalid_Ngo()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Ngo()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Ngo()
	{
		Assert.AreEqual(6, Program.Multiply("2", "3"));
		Assert.AreEqual(0, Program.Multiply("5", "0"));
		Assert.AreEqual(-6, Program.Multiply("2", "-3"));
	}

	[TestMethod]
	public void Multiply_Invalid_Ngo()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Ngo()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Ngo()
	{
		Assert.AreEqual(1.5, Program.Divide("3", "2"));
		Assert.AreEqual(0, Program.Divide("0", "5"));
		Assert.AreEqual(-1.5, Program.Divide("-3", "2"));
	}

	[TestMethod]
	public void Divide_Invalid_Ngo()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_Ngo()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}

	[TestMethod]
	public void Divide_ByZero_Ngo()
	{
		Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("5", "0"));
		Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("0", "0"));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Ngo()
	{
		Assert.AreEqual(4, Program.Power("2", "2"));
		Assert.AreEqual(1, Program.Power("5", "0"));
		Assert.AreEqual(0.25, Program.Power("2", "-2"));
	}

	[TestMethod]
	public void Power_Invalid_Ngo()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_Ngo()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}
