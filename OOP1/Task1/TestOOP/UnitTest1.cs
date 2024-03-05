using ComplexNumClass;

namespace TestOOP
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOperatorPlus()
        {
            //Arrange
            var a = ComplexNum.Alg(1, 2);
            var b = ComplexNum.Trig(5, Math.PI);

            //Act
            var answer = a + b; 


            //Assert
            Assert.AreEqual(-4, answer.RealPart);
            Assert.AreEqual(2, answer.ImaginaryPart);
        }

        [Test]
        public void TestOperatorMinus()
        {
            //Arrange
            var a = ComplexNum.Alg(1, 2);
            var b = ComplexNum.Trig(5, Math.PI);

            //Act
            var answer = a - b;


            //Assert
            Assert.AreEqual(6, answer.RealPart);
            Assert.AreEqual(2, answer.ImaginaryPart);
        }
    }
}