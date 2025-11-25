using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PetrovDR.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(w => w.Length < 7);
            return count;
        }
    }
}
