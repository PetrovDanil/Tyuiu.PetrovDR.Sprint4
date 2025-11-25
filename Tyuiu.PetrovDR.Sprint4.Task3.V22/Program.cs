using Tyuiu.PetrovDR.Sprint4.Task3.V22.Lib;


namespace Tyuiu.PetrovDR.Sprint4.Task3.V22
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
            PrintCenteredLine("Задание #3", width);
            PrintCenteredLine("Вариант #22", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в", width);
            Console.WriteLine("диапазоне от 4 до 9. Найдите максимальный элемент в первой строке массива.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int[,] mas = new int[5, 5] {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            Console.WriteLine();

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Максимальное элемент в первой строке = " + ds.Calculate(mas));

            Console.ReadKey();
        }
    }
}