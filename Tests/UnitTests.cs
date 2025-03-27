namespace GithubActionsLab;
using System;
// using NUnit.Framework;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Do()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Do()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Do()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void Subtract_Valid_Do()
	{
		Assert.AreEqual(3, Program.Subtract("3", "0"));
		Assert.AreEqual(3, Program.Subtract("6", "3"));
		Assert.AreEqual(2, Program.Subtract("7", "5"));
	}

	[TestMethod]
	public void Multiply_Valid_Do()
	{
		Assert.AreEqual(4, Program.Multiply("2", "2"));
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(35, Program.Multiply("5", "7"));
	}
	
	[TestMethod]
	public void Power_Valid_Do()
	{
		Assert.AreEqual(1, Program.Power("1", "2"));
		Assert.AreEqual(9, Program.Power("3", "2"));
		Assert.AreEqual(4, Program.Power("2", "2"));
	}
}
