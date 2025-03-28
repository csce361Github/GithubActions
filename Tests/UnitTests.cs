namespace GithubActionsLab;

[TestClass]
public class Addition
{
    [TestMethod]
    public void Add_Valid_Rojas()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Rojas()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Rojas()
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
    public void Subtract_Valid_Rojas()
    {
        Assert.AreEqual(4, Program.Subtract("5", "1"));
        Assert.AreEqual(2, Program.Subtract("7", "5"));
        Assert.AreEqual(94, Program.Subtract("110", "15")); // Purposely wrong
    }

    [TestMethod]
    public void Subtract_Invalid_Rojas()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("c", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("d", "g"));
    }

    [TestMethod]
    public void Subtract_Null_Rojas()
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
    public void Multiply_Valid_Rojas()
    {
        Assert.AreEqual(5, Program.Multiply("5", "1"));
        Assert.AreEqual(35, Program.Multiply("7", "5"));
        Assert.AreEqual(50, Program.Multiply("5", "10"));
    }

    [TestMethod]
    public void Multiply_Invalid_Rojas()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("c", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("d", "g"));
    }

    [TestMethod]
    public void Multiply_Null_Rojas()
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
    public void Divide_Valid_Rojas()
    {
        Assert.AreEqual(5, Program.Divide("5", "1"));
        Assert.AreEqual(2, Program.Divide("10", "5"));
        Assert.AreEqual(0.5, Program.Divide("5", "10"));
    }

    [TestMethod]
    public void Divide_Invalid_Rojas()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("c", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("d", "g"));
    }

    [TestMethod]
    public void Divide_Null_Rojas()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}
[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_Rojas()
    {
        Assert.AreEqual(5, Program.Power("5", "1"));
        Assert.AreEqual(32, Program.Power("2", "5"));
        Assert.AreEqual(25, Program.Power("5", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Rojas()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Power("c", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("d", "g"));
    }

    [TestMethod]
    public void Power_Null_Rojas()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
