using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubActionsLab; // Import the console app namespace

namespace Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Power_FixedTest()
    {
        double result = Program.Power("2", "3");
        Assert.AreEqual(8, result);
    }
/*
    [TestMethod]
    public void Power_CorrectTest1()
    {
        double result = Program.Power("3", "2");
        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void Power_CorrectTest2()
    {
        double result = Program.Power("1", "5");
        Assert.AreEqual(1, result);
      } */
}