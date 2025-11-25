using Tyuiu.PetrovDR.Sprint4.Task3.V22.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { 
                { 4, 4, 7, 8, 9 }, 
                { 9, 5, 9, 7, 8 }, 
                { 7, 4, 9, 4, 6 }, 
                { 4, 4, 7, 4, 4 }, 
                { 4, 5, 8, 6, 7 } };

            int res = ds.Calculate(mas);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
