using Tyuiu.PetrovDR.Sprint4.Task2.V25.Lib;


namespace Tyuiu.PetrovDR.Sprint4.Task2.V25
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
            PrintCenteredLine("Задание #2", width);
            PrintCenteredLine("Вариант #25", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан одномерный целочисленный массив на 11 элементов заполненный случайными в диапазоне от", width);
            Console.WriteLine("3 до 9 подсчитать произведение четных элементов массива.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            Random rnd = new Random();

            Console.WriteLine("Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(3, 9);
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