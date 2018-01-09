using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Kavokin
{
    public class MatrixOperations
    {
        /// <summary>
        /// Multiplicate 2 matrix
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double[,] Multiplicate(double[,] first, double[,] second)
        {
            if(first.GetLength(1) != second.GetLength(0))
                throw new Exception("Number of columns in First Matrix should be equal to Number of rows in Second Matrix.");
            var result = new double[first.GetLength(0), second.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    double sum = 0;
                    for (int k = 0; k < first.GetLength(1); k++)
                    {
                        sum += first[i, k] * second[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
    }
}
