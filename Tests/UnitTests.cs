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
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
        Assert.AreEqual(0, Program.Subtract("2", "2"));
    }

    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(35, Program.Multiply("5", "7"));
        Assert.AreEqual(0, Program.Multiply("2", "0"));
    }

    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(1.5, Program.Divide("3", "2"), 0.0001);
        Assert.AreEqual(5, Program.Divide("10", "2"));
    }

    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(0.5, Program.Power("2", "-1"), 0.0001);
    }

   
}
