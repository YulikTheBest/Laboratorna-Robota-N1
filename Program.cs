using System;
using System.Globalization;

namespace Laboratorka_1 
{
    public class Program // Головний клас програми
    {
        // Функція для середнього арифметичного
        public static double ArithmeticMean(double a, double b) // Додано модифікатор static
        {
            return (a + b) / 2.0; // Повертає середнє арифметичне
        }

        // Функція для середнього геометричного
        public static double GeometricMean(double a, double b) // Додано модифікатор static
        {
            return Math.Sqrt(a * b); // Повертає середнє геометричне
        }

        static void Main(string[] args) // Головний метод програми
        {
            // Налаштування для української мови
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування виводу
            Console.InputEncoding = System.Text.Encoding.UTF8;// Встановлення кодування вводу
            CultureInfo.CurrentCulture = new CultureInfo("uk-UA"); // Встановлення культури

            double a, b;// Оголошення змінних для зберігання введених чисел

            Console.Write("Введіть число a: ");// Запит на введення першого числа
            while (!double.TryParse(Console.ReadLine(), out a))// Перевірка правильності введення
            {
                Console.Write("Помилка! Введіть число a: ");// Повторний запит у випадку помилки
            }

            Console.Write("Введіть число b: ");
            while (!double.TryParse(Console.ReadLine(), out b))// Перевірка правильності введення
            {
                Console.Write("Помилка! Введіть число b: ");
            }

            double sa = ArithmeticMean(a, b);// Виклик функції для обчислення середнього арифметичного
            double sg = GeometricMean(a, b);// Виклик функції для обчислення середнього геометричного

            Console.WriteLine($"Середнє арифметичне = {sa:F2}");// Виведення результату з форматуванням до 2 знаків після коми
            Console.WriteLine($"Середнє геометричне = {sg:F2}");// Виведення результату з форматуванням до 2 знаків після коми
        }
    }
}
