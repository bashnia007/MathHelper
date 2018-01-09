using System;
using MathHelper.Kavokin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.MathHelper
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZeroA()
        {
            var mathHelper = new global::MathHelper.Kavokin.EquationsOperations();
            var result = mathHelper.CalculateQuadraticEquation(0, 2, -4);
            if (result.Item1 != null) Assert.AreEqual(result.Item1.Value, 2, double.Epsilon);
        }

        [TestMethod]
        public void TestZeroAandBbutNotC()
        {
            var mathHelper = new global::MathHelper.Kavokin.EquationsOperations();
            Assert.ThrowsException<Exception>(() => { mathHelper.CalculateQuadraticEquation(0, 0, -4); });
        }

        [TestMethod]
        public void TestMultiplicateMatrix()
        {
            var mathHelper = new MatrixOperations();
            var firstMatrix = new double[,] {{1, 2, 1}, {0, -1, 2}};
            var secondMatrix = new double[,] {{0, 1, 1}, {1, -1, 1}, {2, -1, -1}};
            var result = mathHelper.Multiplicate(firstMatrix, secondMatrix);
            var estimated = new double[,] {{4, -2, 2}, {3, -1, -3}};
            CollectionAssert.AreEqual(estimated, result);
        }

        [TestMethod]
        public void TestMultiplicateNotEqualRowToColumnMatrix()
        {
            var mathHelper = new MatrixOperations();
            var firstMatrix = new double[,] { { 1, 2, 1 }, { 0, -1, 2 } };
            var secondMatrix = new double[,] { { 0, 1, 1 }, { 1, -1, 1 }, { 2, -1, -1 }, { 2, -1, -1 } };
            Assert.ThrowsException<Exception>(() =>
            {
                mathHelper.Multiplicate(firstMatrix, secondMatrix);
            });
        }

        [TestMethod]
        public void TestMultiplicateEmptyMatrix()
        {
            var mathHelper = new MatrixOperations();
            var firstMatrix = new double[,] {  };
            var secondMatrix = new double[,] { };
            var result = mathHelper.Multiplicate(firstMatrix, secondMatrix);
            var estimated = new double[,] { };
            CollectionAssert.AreEqual(estimated, result);
        }

        [TestMethod]
        public void TestLinearCalculation()
        {
            var helper = new EquationsOperations();
            var result = helper.CalculateLinearEquation(2, -4);
            Assert.AreEqual(2, result);
        }
    }
}
