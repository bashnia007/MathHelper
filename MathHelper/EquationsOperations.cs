using System;

namespace MathHelper.Kavokin
{
    public class EquationsOperations
    {
        /// <summary>
        /// Calcaulates quadratic equation "ax² + bx + c = 0"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Roots of quadratic equation(allow nullable) or Exception in case of no roots</returns>
        public Tuple<double?, double?> CalculateQuadraticEquation(double a, double b, double c)
        {
            if (Math.Abs(a) < double.Epsilon)
            {
                if (Math.Abs(b) < double.Epsilon)
                {
                    throw new Exception("There are no roots");
                }
                return new Tuple<double?, double?>(-c/b, null);
            }
            var d = Math.Pow(b, 2) - 4 * a*c;
            if (d < 0) return new Tuple<double?, double?>(null, null);

            var x1 = (-b - Math.Sqrt(d)) / (2 * a);
            var x2 = (-b + Math.Sqrt(d)) / (2 * a);

            return new Tuple<double?, double?>(x1, x2);
        }

        /// <summary>
        /// Calculates linear equation "ax + b = 0"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Roots of linear equation or Exception in case of no roots or all real numbers</returns>
        public double CalculateLinearEquation(double a, double b)
        {
            if (Math.Abs(a) < double.Epsilon)
            {
                if (Math.Abs(b) < double.Epsilon)
                {
                    throw new Exception("All real numbers are roots");
                }
                throw new Exception("There are no roots");
            }
            return -b / a;
        }
    }
}
