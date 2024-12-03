using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите верхнюю границу (только цифры): ");
            decimal levelUp = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите нижнюю границу (только цифры): ");
            decimal levelDown = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите шаг уровня (только цифры): ");
            decimal stepSize = Convert.ToDecimal(Console.ReadLine());

            // Определяем количество уровней 
            try
            {
                int stepLevels = (int)((levelUp - levelDown) / stepSize) + 1;
                
                Console.WriteLine($"\nВаши текущие значения:\n" +
                $"Верхняя граница = {levelUp}\n" +
                $"Нижняя граница = {levelDown}\n" +
                $"Шаг уровня = {stepSize}\n" +
                $"Предлагаемое количество уровней = до {stepLevels}\n");


                Console.WriteLine("\nВведены верные значения? Yes - 1 No - 0");

                int answerData = Convert.ToInt32(Console.ReadLine());

                var stepLevelsArray = new List<decimal>();

                // Проверка на правильность введенных данных. Согласие пользователя
                if (answerData == 1)
                {
                    // Проверка на реальную правильность введенных данных
                    if (levelUp >= levelDown + stepSize)
                    {
                        int levelNumber = 1;
                        for (decimal i = levelDown; i <= levelUp; i = i + stepSize)
                        {

                            stepLevelsArray.Add(i);
                            Console.WriteLine($"Уровень #{levelNumber} : {i}");
                            levelNumber += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введены неверные данные или невозможно определить уровни");
                    }
                }
                else
                {
                    Console.WriteLine("\nПерезапустите программу и введите правильные значения");
                }
                Console.WriteLine($"\nКоличество уровней в массиве = {stepLevelsArray.Count}\n");
            }
            catch
            {
                Console.WriteLine("Возникло исключение! Возможно введены неверные данные или вы поделили на ноль");
            }



        }
    }
}