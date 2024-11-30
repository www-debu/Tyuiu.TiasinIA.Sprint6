using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Массив для временного хранения значений третьего столбца.
            int[] tColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                tColumn[i] = matrix[i, 2]; // Используем третий столбец (индекс 2).
            }

            // Сортируем значения третьего столбца и сохраняем индексы.
            int[] sortedIndexes = Enumerable.Range(0, rows).ToArray();
            Array.Sort(tColumn, sortedIndexes);

            // Создаем новый массив для отсортированных данных.
            int[,] sortedArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                int originalRowIndex = sortedIndexes[i]; // Индекс оригинальной строки.
                for (int j = 0; j < columns; j++)
                {
                    sortedArray[i, j] = matrix[originalRowIndex, j]; // Копируем значения из оригинальной матрицы.
                }
            }

            return sortedArray;
        }
    }
}
