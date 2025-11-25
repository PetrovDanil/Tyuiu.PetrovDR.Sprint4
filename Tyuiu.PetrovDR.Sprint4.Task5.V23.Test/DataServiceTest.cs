using Tyuiu.PetrovDR.Sprint4.Task5.V23.Lib;

namespace Tyuiu.PetrovDR.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 7, -4, 7, 6, 7 },
                { -4, -4, 8, 6, 7 },
                { 8, 6, 5, 6, 7 },
                { -2, -4, 7, 8, 7 },
                { 5, -1, -1, 8, 0 } };

            int[,] matrixWAIT = new int[5, 5] {
                { 7, 0, 7, 6, 7 },
                { 0, 0, 8, 6, 7 },
                { 8, 6, 5, 6, 7 },
                { 0, 0, 7, 8, 7 },
                { 5, 0, 0, 8, 0 } };

            int[,] matrixRES = ds.Calculate(matrix);
            CollectionAssert.AreEqual(matrixWAIT, matrixRES);
        }
    }
}
