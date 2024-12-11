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
            for (int i = 0; i <= rows; i++)
            {
                firstColumn[i] = matrix[i, 2];
            }

            Array.Sort(firstColumn);

            
            for (int i = 0; i <= firstColumn.Length; i++)
            {
                matrix[2,i] = firstColumn[i];
            }

            return matrix;
        }
    }
}
