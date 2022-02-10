using System;
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

        [TestCase(12, 34, 46)]
        [TestCase(-13, 34, 21)]
        [TestCase(0, 123, 123)]
        [TestCase(0, 0, 0)]
        public void Add_Numbers(double a, double b, double r)
        {
            //Arrange
            //var uut = new CalculatorClass();

           
           
            //Assert + Act
            Assert.That(uut.Add(a,b), Is.EqualTo(r));

        }



        [TestCase(12, 34, -22)]
        [TestCase(-13, 34, -47)]
        [TestCase(0, 123, -123)]
        [TestCase(0, 0, 0)]
        public void Subtract_20_5_ResultIs15(double a, double b, double r)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(r));
        }

        [TestCase(12, 34, 408)]
        [TestCase(-13, 34, -442)]
        [TestCase(0, 123, 0)]
        [TestCase(0, 0, 0)]

        public void MultiplyTest(double a, double b, double r)
        {
            Assert.That(uut.Multiply(a,b), Is.EqualTo(r));
        }


        [TestCase(6, 5, 1.2)]
        [TestCase(-3, 3, -1)]
        [TestCase(0, 123, 0)]

        public void DivideTest(double a, double b, double r)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(r));
        }

        [Test]

        public void Divide_Zero_Throws()
        {
            //Arrange

            //Act


            //Assert + Act
            Assert.That(() => uut.Divide(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        [Test]

        public void AccumulatorTest_Add()
        {
            //Arrange

            //Act
            uut.Add(23, 4);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(27));
        }


        [Test]

        public void AccumulatorTest_Subtract()
        {
            //Arrange

            //Act
            uut.Subtract(23, 4);


            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(19));
        }


        [TestCase(23, 69)]
        [TestCase(-3, -9)]
        [TestCase(5, 15)]

        public void AccumulatorTest_Add_Chained(double a, double r)
        {
            //Arrange

            //Act
            uut.Add(a);
            uut.Add(a);
            uut.Add(a);


            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(r));
        }

        [TestCase(23, -23)]
        [TestCase(-3, 3)]
        [TestCase(5, -5)]

        public void AccumulatorTest_Substract_Chained(double a, double r)
        {
            //Arrange

            //Act
            uut.Accumulator = a;
            uut.Subtract(a);
            uut.Subtract(a);


            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(r));
        }

        [TestCase(23, 12167)]
        [TestCase(-3, -27)]
        [TestCase(5, 125)]

        public void AccumulatorTest_Multiply_Chained(double a, double r)
        {
            //Arrange

            //Act
            uut.Accumulator = a;
            uut.Multiply(a);
            uut.Multiply(a);


            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(r));
        }

        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        [TestCase(5, 0.2)]

        public void AccumulatorTest_Divide_Chained(double a, double r)
        {
            //Arrange

            //Act
            uut.Accumulator = a;
            uut.Divide(a);
            uut.Divide(a);


            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(r));
        }


        [TestCase(23)]
        [TestCase(-3)]
        [TestCase(0)]

        public void AccumulatorTest_Clear(double a)
        {
            //Arrange

            //Act
            uut.Add(a);
            uut.Add(a);
            uut.Add(a);
            uut.Clear();

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        [TestCase(2, 3, 8)]
        [TestCase(5, 5, 3125)]
        [TestCase(7, 3, 343)]

        public void Power(double a, double b, double r)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(r));
        }















    }
}