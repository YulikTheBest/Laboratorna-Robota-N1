using Microsoft.VisualStudio.TestTools.UnitTesting; // Простір імен для модульного тестування

namespace TestProject1 // Простір імен для тестового проекту
{
    [TestClass]
    public sealed class Test1 // Тестовий клас для перевірки функцій середнього арифметичного та геометричного
    {
        [TestMethod]
        public void ArithmeticMean_Test()// Тестовий метод для перевірки функції ArithmeticMean
        {
            // Arrange
            double a = 5;// Підготовка вхідних даних
            double b = 7;// Підготовка вхідних даних

            // Act
            double result = Laboratorka_1.Program.ArithmeticMean(a, b);// Виклик тестованої функції

            // Assert
            Assert.AreEqual(6.0, result, 0.0001, "ArithmeticMean має повертати середнє арифметичне чисел");// Перевірка результату
        }

        [TestMethod]
        public void GeometricMean_Test()// Тестовий метод для перевірки функції GeometricMean
        {
            // Arrange
            double a = 4;// Підготовка вхідних даних
            double b = 9;// Підготовка вхідних даних

            // Act
            double result = Laboratorka_1.Program.GeometricMean(a, b);// Виклик тестованої функції

            // Assert
            Assert.AreEqual(6.0, result, 0.0001, "GeometricMean має повертати середнє геометричне чисел");// Перевірка результату
        }
    }
}
