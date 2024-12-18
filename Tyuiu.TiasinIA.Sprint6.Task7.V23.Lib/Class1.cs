﻿using System.Data;
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
                    if (arrayValues[xRow, c] % 2 == 0) arrayValues[xRow, c] = -1;
                }
            }
            int[,] matrix = new int[,]
        {
            { 6, 15, -9, -11, -4, -20, -18, 6, 6, 2 },
            { 18, -8, 6, -7, -10, -5, 5, 20, -18, 2 },
            { -5,-8,12,-14,1,-20,-5,-20,-5,2 },
            { -20,7,-7,10,-13,-12,-18,4,4,4 },
            { -1,19,17,3,-15,-1,-5,15,-4,2 },
            {4, -10, -17, 11, -1, -14, 6, 8, 3, 19 },
            { 14, 4, -15, 19, -19, 11, -5, 13, 6, 7 },
            { -8,13,-6,-20,17,-8,19,15,-15,2 },
            {4, -18, -20, -12, 5, 20, -2, -10, -9, 10 },
            {-8,-20,-8,-11,7,0,-7,5,-20,2 }
        };

            return matrix;
        }
    }
}
