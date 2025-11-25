using Tyuiu.PetrovDR.Sprint4.Task5.V23.Lib;


namespace Tyuiu.PetrovDR.Sprint4.Task4.V24
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
            PrintCenteredLine("Задание #5", width);
            PrintCenteredLine("Вариант #23", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными", width);
            Console.WriteLine("значениями в диапазоне от -4 до 8. Заменить отрицательные элементы на 0.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            Random rnd = new Random();
            

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];




            Console.WriteLine(new string('*', width));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 8);
                }
            }




            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }






            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("\nИзмененный массив: ");

            var result = ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}