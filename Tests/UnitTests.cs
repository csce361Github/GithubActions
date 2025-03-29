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
	public void Subtract_Valid_Fruhling()
	{
		Assert.AreEqual(3, Program.Subtract("5", "2"));
		Assert.AreEqual(5, Program.Subtract("7", "2"));
		Assert.AreEqual(12, Program.Subtract("14", "2"));
	}
	 [TestMethod]
    public void Subtract_Invalid_Fruhling()
    {
         Assert.ThrowsException<FormatException>(() => Program.Subtract("5", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));

    }

    [TestMethod]
    public void Subtract_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("5", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));

    }

}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Fruhling()
	{
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(0, Program.Multiply("0", "2"));
		Assert.AreEqual(12, Program.Multiply("2", "6"));
	}
 	[TestMethod]
    public void Multiply_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("3", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));

    }

    [TestMethod]
    public void Multiply_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("3", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null)); 

    }
}
[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Fruhling()
	{
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(2, Program.Divide("14", "7"));
	}
 	[TestMethod]
    public void Divide_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("6", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));

    }

    [TestMethod]
    public void Divide_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("6", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Fruhling()
	{
		Assert.AreEqual(4, Program.Power("2", "2"));
		Assert.AreEqual(49, Program.Power("7", "2"));
		Assert.AreEqual(8, Program.Power("2", "3"));
	}
    [TestMethod]
    public void Power_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Power_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}