using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;
using testing_calculator;

namespace xunit_test
{
    public class UnitTest1
    {
        double[] testArray = new double[] { 2, 3, 4, 5, 1 };
        calc myCalc = new calc();
        [Fact]
        public void PassingTest()
        {
            //Assert.Equal(7, myCalc.Addition(2, 5));
            Assert.Equal(15, myCalc.Addition(testArray));
            Assert.Equal(2, myCalc.Subtraction(3, 1));
            Assert.Equal(2, myCalc.Multiplication(1, 2));
            Assert.Equal(2, myCalc.Division(2, 1));
            Assert.Equal(-11, myCalc.Subtraction(testArray));
        }
        [Fact]
        public void FailingTest()
        {
            //Assert.Equal(1, myCalc.Addition(2, 5));
            Assert.Equal(1, myCalc.Addition(testArray));
            Assert.Equal(1, myCalc.Subtraction(3, 1));
            Assert.Equal(1, myCalc.Multiplication(1, 2));
            Assert.Equal(1, myCalc.Division(1, 2));
            Assert.Equal(1, myCalc.Subtraction(testArray));
        }
    }
    }
