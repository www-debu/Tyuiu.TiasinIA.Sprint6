using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task7.V23.Lib
{
    public class Class1 : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            var lines = File.ReadAllLines(path);
            DataTable dataTable = new DataTable();

            // Создает столбцы для DataTable
            foreach (var header in lines[0].Split(','))
            {
                dataTable.Columns.Add(header);
            }

            // Заполняет DataTable данными
            for (int i = 1; i < lines.Length; i++)
            {
                var row = lines[i].Split(',');
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public DataTable ProcessMatrix(DataTable inputTable)
        {
            DataTable outputTable = inputTable.Copy();
            int lastColumnIndex = outputTable.Columns.Count - 1;

            // Изменяет значения в последнем столбце
            foreach (DataRow row in outputTable.Rows)
            {
                if (int.TryParse(row[lastColumnIndex].ToString(), out int value))
                {
                    if (value < 2)
                    {
                        row[lastColumnIndex] = 2;
                    }
                }
            }

            return outputTable;
        }
    }
}
