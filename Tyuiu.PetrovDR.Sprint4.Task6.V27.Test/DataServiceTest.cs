using Tyuiu.PetrovDR.Sprint4.Task6.V27.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var figures = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(figures);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
