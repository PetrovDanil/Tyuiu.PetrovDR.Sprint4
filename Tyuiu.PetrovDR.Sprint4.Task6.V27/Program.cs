using Tyuiu.PetrovDR.Sprint4.Task6.V27.Lib;


namespace Tyuiu.PetrovDR.Sprint4.Task6.V27
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
            PrintCenteredLine("Задание #6", width);
            PrintCenteredLine("Вариант #27", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан строковый массив данных. Используя класс Array подсчитайте количество элементов,", width);
            Console.WriteLine("длина которых меньше 7.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            var figures = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine(figures[i]);
            }


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Кол-во элементов: " + ds.Calculate(figures));

            Console.ReadKey();
        }
    }
}