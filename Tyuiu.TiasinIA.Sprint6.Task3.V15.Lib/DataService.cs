using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }


            Array.Sort(firstColumn);


            int[,] sortedArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                sortedArray[i, 0] = firstColumn[i];
                for (int j = 1; j < cols; j++)
                {

                    int originalRowIndex = Array.IndexOf(firstColumn, sortedArray[i, 0]);
                    sortedArray[i, j] = matrix[originalRowIndex, j];
                }
            }

            return sortedArray;
        }
    }
}
