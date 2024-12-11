using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[,] tempArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tempArray[i, j] = matrix[i, j];
                }
            }


            Array.Sort(tempArray, (a, b) => a[2].CompareTo(b[2]));


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = tempArray[i, j];
                }
            }

            return matrix;
        }
    }
}
