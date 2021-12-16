using System;

namespace LibMatrix
{
    public class CalculateModules
    {
        public string GetMinimum(int[,] matrix)
        {
            int count = matrix.GetLength(1), min;
            string result = string.Empty;

            for (int i = 0; i < matrix.GetLength(0); i ++)
            {
                min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] < min)
                        min = matrix[i, j];
                }
                result += ($"В {i} строке минимальный элемент = {min}\n");
            }
            return result; 
        }
    }
}
