using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PetrovDR.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;

            int max = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                if (array[i,0] > max)
                {
                    max = array[i,0];
                }
            }
            return max;
        }
    }
}
