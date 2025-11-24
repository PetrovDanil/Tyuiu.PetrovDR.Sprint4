using Tyuiu.PetrovDR.Sprint4.Task2.V25.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numArray = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6 };
            int res = ds.Calculate(numArray);
            int wait = 5184;
            Assert.AreEqual(wait, res);
        }
    }
}
