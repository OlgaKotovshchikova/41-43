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
             * y = k1 * x + b1
             * y = k2 * x + b2; 
             * значения b1, k1, b2 и k2 задаются пользователем.
             * b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)*/

           // k1 и k2 - угловые коэф.
           // b1 и b2 - пересечение прямых с осью y

            static void TaskFourtythree()
            {
                Console.Write("Введите угловой коэффициент первой прямой (k1): ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите пересечение первой прямой с осью y (b1): ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите угловой коэффициент второй прямой (k2): ");
                double k2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите пересечение второй прямой с осью y (b2): ");
                double b2 = Convert.ToDouble(Console.ReadLine());

                if ((k1 == k2) & (b1 != b2)) Console.WriteLine("Прямые различны и не пересекаются");
                if ((k1 == k2) & (b1 == b2)) Console.WriteLine("Прямые совпадают");
                if (k1 == k2) Console.WriteLine("Прямые параллельны");
                
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.WriteLine("("+$"{x}; "+$"{y}"+")");
            }
            #endregion
        }
    }
}
