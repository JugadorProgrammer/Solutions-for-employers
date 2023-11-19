using AreaCalculatorLib;

namespace AreaCalculatorTest
{
    [TestClass]
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Тест на корректность подсчёта площади круга с радиусом 10. Ожидается 314,159265358979323846
        /// </summary>
        [TestMethod]
        public void ColculateCircleShape_10_314return()
        {
            // Arrange
            double radius = 10;
            double expected = 100 * Math.PI;

            // Act
            AreaCalculator areaCalculator = new AreaCalculator();
            double actual = areaCalculator.ColculateCircleShape(radius);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на корректность подсчёта площади круга с радиусом 1. Ожидается 3,14159265358979323846
        /// </summary>
        [TestMethod]
        public void ColculateCircleShape_1_3return()
        {
            // Arrange
            double radius = 1;
            double expected = Math.PI;

            // Act
            AreaCalculator areaCalculator = new AreaCalculator();
            double actual = areaCalculator.ColculateCircleShape(radius);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на корректность подсчёта площади круга с радиусом -1. Ожидается ArgumentException с Message="Радиус должен быть больше нуля!"
        /// </summary>
        [TestMethod]
        public void ColculateCircleShape_minus1_ShouldThrowArgumentException()
        {
            // Arrange
            double radius = -1;
            try
            {
                // Act
                AreaCalculator areaCalculator = new AreaCalculator();
                double actual = areaCalculator.ColculateCircleShape(radius);
            }
            catch (ArgumentException exception)
            {
                // Assert
                StringAssert.Contains(exception.Message, "Радиус должен быть больше нуля!");
            }
        }
        /// <summary>
        /// Тест на корректность подсчёта площади треугольника со сторонами 3,4,5 прямоугольным. Ожидается 6
        /// </summary>
        [TestMethod]
        public void ColculateTringleShape_3and4and5_6return()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            // Act
            AreaCalculator areaCalculator = new AreaCalculator();
            double actual = areaCalculator.TringleShape(a, b, c);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на корректность подсчёта площади треугольника со сторонами 10,4,5 прямоугольным. Ожидается ArgumentException с Message="Наибольшая сторона треугольника не может быть больше суммы двух других сторон!"
        /// </summary>
        [TestMethod]
        public void ColculateTringleShape_10and4and5_ShouldThrowArgumentException()
        {
            // Arrange
            double a = 10;
            double b = 4;
            double c = 5;
            try
            {
                // Act
                AreaCalculator areaCalculator = new AreaCalculator();
                double actual = areaCalculator.TringleShape(a, b, c);
            }
            catch (ArgumentException exception)
            {
                // Assert
                StringAssert.Contains(exception.Message, "Наибольшая сторона треугольника не может быть больше суммы двух других сторон!");
            }
        }
        /// <summary>
        /// Тест на корректность подсчёта площади треугольника со сторонами -1,4,5 прямоугольным. Ожидается ArgumentException с Message="Сторона трегольника должна быть больше нуля!"
        /// </summary>
        [TestMethod]
        public void ColculateTringleShape_minus1and4and5_ShouldThrowArgumentException()
        {
            // Arrange
            double a = -1;
            double b = 4;
            double c = 5;
            try
            {
                // Act
                AreaCalculator areaCalculator = new AreaCalculator();
                double actual = areaCalculator.TringleShape(a, b, c);
            }
            catch (ArgumentException exception)
            {
                // Assert
                StringAssert.Contains(exception.Message, "Сторона трегольника должна быть больше нуля!");
            }
        }
        /// <summary>
        /// Тест на корректность проверки является ли треугольник со сторонами 3,4,5 прямоугольным. Ожидается true
        /// </summary>
        [TestMethod]
        public void isRightRriangle_3and4and5_truereturn()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            // Act
            AreaCalculator areaCalculator = new AreaCalculator();
            bool actual = areaCalculator.isRightRriangle(a, b, c);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на корректность проверки является ли треугольник со сторонами 3,6,5 прямоугольным. Ожидается false
        /// </summary>
        [TestMethod]
        public void isRightRriangle_3and6and5_falsereturn()
        {
            // Arrange
            double a = 3;
            double b = 6;
            double c = 5;
            bool expected = false;
            // Act
            AreaCalculator areaCalculator = new AreaCalculator();
            bool actual = areaCalculator.isRightRriangle(a, b, c);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на корректность проверки является ли треугольник со сторонами 10,4,5 прямоугольным. Ожидается исключения с Message="Наибольшая сторона треугольника не может быть больше суммы двух других сторон!"
        /// </summary>
        [TestMethod]
        public void isRightRriangle_10and4and5_ShouldThrowArgumentException()
        {
            // Arrange
            double a = 10;
            double b = 4;
            double c = 5;
            try
            {
                // Act
                AreaCalculator areaCalculator = new AreaCalculator();
                bool actual = areaCalculator.isRightRriangle(a, b, c);
            }
            catch (ArgumentException exception)
            {
                // Assert
                StringAssert.Contains(exception.Message, "Наибольшая сторона треугольника не может быть больше суммы двух других сторон!");
            }
        }
        /// <summary>
        /// Тест на корректность проверки является ли треугольник со сторонами -1,4,5 прямоугольным. Ожидается исключения с Message="Сторона трегольника должна быть больше нуля!"
        /// </summary>
        [TestMethod]
        public void isRightRriangle_minus1and4and5_ShouldThrowArgumentException()
        {
            // Arrange
            double a = -1;
            double b = 4;
            double c = 5;
            try
            {
                // Act
                AreaCalculator areaCalculator = new AreaCalculator();
                bool actual = areaCalculator.isRightRriangle(a, b, c);
            }
            catch (ArgumentException exception)
            {
                // Assert
                StringAssert.Contains(exception.Message, "Сторона трегольника должна быть больше нуля!");
            }
        }
    }
}