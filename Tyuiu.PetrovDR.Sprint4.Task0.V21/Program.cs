using Tyuiu.PetrovDR.Sprint4.Task0.V21.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task0.V21
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
            PrintCenteredLine("Задание #0", width);
            PrintCenteredLine("Вариант #21", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями", width);
            Console.WriteLine("в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int[] numsArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.WriteLine("Массив:  ");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Сумма четных элементов = " + ds.GetSumEvenArrEl(numsArray));

            Console.ReadKey();
        }
    }
}