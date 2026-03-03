using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubActionsLab;  // Namespace of your console app

namespace CalculatorTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestAdd_Clausen()
        {
            double result = Program.Add("2", "3");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtract_Clausen()
        {
            double result = Program.Subtract("5", "3");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply_Clausen()
        {
            double result = Program.Multiply("4", "3");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestDivide_Clausen()
        {
            double result = Program.Divide("10", "2");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestPower_Clausen()
        {
            double result = Program.Power("2", "3");
            Assert.AreEqual(8, result);
        }
    }
}