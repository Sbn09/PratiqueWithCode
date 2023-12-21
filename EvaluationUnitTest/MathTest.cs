using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationUnitTest
{
    [TestClass]
    public class MathTest
    {
        [DataTestMethod]

        [DataRow(3, 3, 6)]
        [DataRow(4, 2, 6)]
        public void Add_WhenCalled_ReturnsSum(int numberOne, int numberTwo, int Sum)
        {
            MathOperations mathOperations = new MathOperations();
            int result = mathOperations.Add(numberOne, numberTwo);
            Assert.AreEqual(Sum, result);
        }

        [DataTestMethod]

        [DataRow(10, 2, 5)]
        [DataRow(4, 2, 2)]
        public void Divide_WhenCalled_ReturnsSum(int numberOne, int numberTwo, float Sum)
        {
            MathOperations mathOperations = new MathOperations();
            int result = (int)mathOperations.Divide(numberOne, numberTwo);
            Assert.AreEqual(Sum, result);
        }

        [TestMethod]

        public void Divide_ByZero_ThrowsExcpetionArgumentException()
        {
            MathOperations mathOperations = new MathOperations();
            Assert.ThrowsException<ArgumentException>(() => mathOperations.Divide(5, 0));
        }

        [TestMethod]
         public void GetOddNumbers_WithNegativeLimit_ThrowsExceptionArgumentException()
         {
            MathOperations mathOperations = new MathOperations();
            Assert.ThrowsException<ArgumentException>(() => mathOperations.GetOddNumbers(-5));
         }

        [TestMethod]
        public void GetOddNumbers()
        {

        }
    }

}
