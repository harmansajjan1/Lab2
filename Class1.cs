using System;
using NUnit.Framework;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class CalculatorTest
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            {

                //Arrange             
                double number1 = 3.4;
                double number2 = 5.6;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetAddition();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetAddition_Input3point5and5point7_Returns9point2()
            {

                //Arrange             
                double number1 = 3.5;
                double number2 = 5.7;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetAddition();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input3point6and5point8_Returns9point4()
            {

                //Arrange             
                double number1 = 3.5;
                double number2 = 5.7;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetAddition();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input7point5and3point7_Returns3point8()
            {

                //Arrange             
                double number1 = 7.5;
                double number2 = 3.7;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetSubtraction();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubstraction_Input8point5and2point7_Returns5point8()
            {

                //Arrange             
                double number1 = 8.5;
                double number2 = 2.7;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetSubtraction();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input9point5and4point7_Returns4point8()
            {

                //Arrange             
                double number1 = 9.5;
                double number2 = 4.7;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetSubtraction();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input4point6and5point7_Returns26point22()
            {

                //Arrange             
                double number1 = 4.6;
                double number2 = 5.7;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetMultiplication();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input8point6and3point7_Returns31point82()
            {

                //Arrange             
                double number1 = 8.6;
                double number2 = 3.7;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetMultiplication();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input3point6and4point7_Returns16point92()
            {

                //Arrange             
                double number1 = 3.6;
                double number2 = 4.7;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetMultiplication();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input24and6_Returns4()
            {

                //Arrange             
                double number1 = 24;
                double number2 = 6;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetDivision();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input25and5_Returns5()
            {

                //Arrange             
                double number1 = 25;
                double number2 = 5;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetDivision();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input24and8_Returns3()
            {

                //Arrange             
                double number1 = 24;
                double number2 = 8;

                double expectedResult = number1 / number2;

                Calc testCalc = new Calc(number1, number2);

                //Act          
                double actualResult = testCalc.GetDivision();

                //Assert         
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}


