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
public class subtractTest
{
    [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(2, Program.Subtract("5", "7"));
        Assert.AreEqual(0, Program.Subtract("2", "2"));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "7"));
        Assert.AreEqual(-15, Program.Multiply("-3", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("3", null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("3", null));
    }

}

[TestClass]
public class PowerTest
{
    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(16, Program.Power("4", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
    }

    [TestMethod]
    public void Power_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("3", null));
    }
}

