using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;

namespace GeometryLibraryTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            // Тест проверяет, правильно ли вычисляется площадь круга
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 1e-10);
        }

        [TestMethod]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            // Тест проверяет, правильно ли вычисляется площадь треугольника
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6;

            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 1e-10);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsTrueForRightTriangle()
        {
            // Тест проверяет, является ли треугольник прямоугольным
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.IsTrue(isRightAngled);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightTriangle()
        {
            // Тест проверяет, не является ли треугольник прямоугольным
            Triangle triangle = new Triangle(5, 5, 5);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.IsFalse(isRightAngled);
        }

        [TestMethod]
        public void CalculateArea_WithDifferentShapes_ReturnsCorrectAreas()
        {
            // Тест проверяет вычисление площади для разных фигур (без знания их типа во время компиляции)
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);

            double expectedCircleArea = Math.PI * 25;
            double expectedTriangleArea = 6;

            double actualCircleArea = circle.GetArea();
            double actualTriangleArea = triangle.GetArea();

            Assert.AreEqual(expectedCircleArea, actualCircleArea, 1e-10);
            Assert.AreEqual(expectedTriangleArea, actualTriangleArea, 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            // Тест проверяет, выбрасывается ли исключение для треугольника с некорректными сторонами
            var triangle = new Triangle(1, 2, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_NegativeRadius_ThrowsArgumentException()
        {
            // Тест проверяет, выбрасывается ли исключение для круга с отрицательным радиусом
            var circle = new Circle(-5);
        }
    }
}
