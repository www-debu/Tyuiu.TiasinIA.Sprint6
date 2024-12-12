using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task7.V23.Lib
{
    public class Class1 : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            // LoadFromFileData, так как из аргументов только путь :D
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            rows = arrayValues.GetUpperBound(0) + 1;
            columns = arrayValues.Length / rows;

            int xRow = 4;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (arrayValues[xRow, c] % 2 != 0) arrayValues[xRow, c] = -1;
                }
            }

            return arrayValues;
        }
    }
}
