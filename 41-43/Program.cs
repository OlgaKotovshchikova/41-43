using System;

namespace _41_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задачи - 41 или 43: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 41:
                    TaskFourtyone();
                    break;
                case 43:
                    TaskFourtythree();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }
            #region Задача 41
            /*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
             * 0, 7, 8, -2, -2-> 2
             * 1, -7, 567, 89, 223-> 3*/

            static void TaskFourtyone()
            {
                Console.WriteLine("Введите числа через пробел: ");
                string[] numbers = Console.ReadLine().Split(' ');

                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Convert.ToInt32(numbers[i]) > 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            #endregion

            #region Задача 43
            /*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
             * y = k1 * x + b1, y = k2 * x + b2; 
             * значения b1, k1, b2 и k2 задаются пользователем.
             * b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

            static void TaskFourtythree()
            {

            }

            #endregion
        }
    }
}
