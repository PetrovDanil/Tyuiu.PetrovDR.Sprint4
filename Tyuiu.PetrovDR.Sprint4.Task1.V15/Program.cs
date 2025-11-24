using Tyuiu.PetrovDR.Sprint4.Task1.V15.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task1.V15
{
    class Program
    {

        static void Main(string[] args)
        {
            void PrintCenteredLine(string text, int totalWidth)
            {
                var padding = totalWidth - text.Length - 2;
                Console.WriteLine($"* {text}{new string(' ', padding)}*");
            }
            var width = 100;



            DataService ds = new DataService();

            PrintCenteredLine("Спринт #4 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #4", width);
            PrintCenteredLine("Тема: Обработка структурных типов", width);
            PrintCenteredLine("Задание #1", width);
            PrintCenteredLine("Вариант #15", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры", width);
            Console.WriteLine("в диапазоне от 4 до 9 подсчитать произведение четных элементов массива.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива:");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Произведение четных элементов = " + ds.Calculate(numsArray));

            Console.ReadKey();
        }
    }
}