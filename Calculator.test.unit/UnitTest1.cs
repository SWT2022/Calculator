using NUnit.Framework;

namespace Calculator.test.unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        
        private CalculatorClass uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [Test]
        public void Add_4_5_ResultIs9()
        {
            //Arrange
            //var uut = new CalculatorClass();

            //Act
            uut.Add(4, 5);
            //Assert
            Assert.That(uut.Add(4, 5), Is.EqualTo(9));

        }

        [Test]

        public void Add_Negative_Numbers()
        {
            Assert.That(uut.Add(-6, -3), Is.EqualTo(-9));
        }


        [Test]
        public void Subtract_20_5_ResultIs15()
        {
            Assert.That(uut.Subtract(20, 5), Is.EqualTo(15));
        }

        [TestCase(12, 34, 408)]
        [TestCase(-13, 34, -442)]
        [TestCase(0, 123, 0)]
        [TestCase(0, 0, 0)]

        public void MultiplyTest(double a, double b, double r)
        {
            Assert.That(uut.Multiply(a,b), Is.EqualTo(r));
        }





    }
}