/*
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
*/
	using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Power_FixedTest()
        {
            // Corrected expected value
            int result = Program.Power(2, 3); // 2^3 = 8
            Assert.AreEqual(8, result); 
        }

        [TestMethod]
        public void Power_CorrectTest1()
        {
            int result = Program.Power(3, 2); // 3^2 = 9
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Power_CorrectTest2()
        {
            int result = Program.Power(1, 5); // 1^5 = 1
            Assert.AreEqual(1, result);  
        }
    }
}