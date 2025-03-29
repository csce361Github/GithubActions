namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Timmons()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Timmons()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Timmons()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
    [TestMethod]
    public void Subtract_Valid_Timmons()
    {
        Assert.AreEqual(1, Program.Subtract("7", "6"));
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(6, Program.Subtract("13", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Timmons()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Timmons()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
    [TestMethod]
    public void Multiply_Valid_Timmons()
    {
        Assert.AreEqual(42, Program.Multiply("7", "6"));
        Assert.AreEqual(10, Program.Multiply("5", "2"));
        Assert.AreEqual(0, Program.Multiply("0", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Timmons()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Multiply_Null_Timmons()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
    [TestMethod]
    public void Divide_Valid_Timmons()
    {
        Assert.AreEqual(5, Program.Divide("30", "6"));
        Assert.AreEqual(3, Program.Divide("6", "2"));
        Assert.AreEqual(6, Program.Divide("42", "7"));
    }

    [TestMethod]
    public void Divide_Invalid_Timmons()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Divide_Null_Timmons()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
    [TestMethod]
    public void Power_Valid_Timmons()
    {
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(4, Program.Power("2", "2"));
        Assert.AreEqual(8, Program.Power("2", "3"));
    }

    [TestMethod]
    public void Power_Invalid_Timmons()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Power_Null_Timmons()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
