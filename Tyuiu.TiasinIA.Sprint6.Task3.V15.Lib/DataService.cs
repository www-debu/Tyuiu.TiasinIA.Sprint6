﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int[] tColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                tColumn[i] = matrix[i, 2];
            }


            Array.Sort(tColumn);


            int[,] sortedArray = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                sortedArray[i, 2] = tColumn[i];
                for (int j = 1; j < colums; j++)
                {
                        int originalRowIndex = Array.IndexOf(tColumn, sortedArray[i, 2]);
                        sortedArray[i, j] = matrix[originalRowIndex, j];
                        
                }
            }

            return sortedArray;
        }
    }
}
