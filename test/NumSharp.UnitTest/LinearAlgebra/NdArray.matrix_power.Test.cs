using System;
using System.Collections.Generic;
using System.Text;
using NumSharp.Core.Extensions;
using System.Linq;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.Core;

namespace NumSharp.UnitTest.Extensions
{
    /// <summary>
    /// Test concolve with standard example from 
    /// https://www.numpy.org/devdocs/reference/generated/numpy.convolve.html
    /// </summary>
    [TestClass]
    public class NdArrayMatrixPowerTest 
    {
        [TestMethod]
        public void ZeroPowerTest()
        {
            var nd1 = new NDArray(typeof(double),3,3);

            var onces = nd1.matrix_power(0).MakeGeneric<double>();

            double[,] expected = new double[,] {{1,0,0},{0,1,0},{0,0,1}};

            for(int idx = 0; idx < 3;idx++)
                for(int jdx = 0; jdx < 3;jdx++)
                    Assert.IsTrue(expected[idx,jdx] == onces[idx,jdx]);
        }
        [TestMethod]
        public void PowerOf3Test()
        {
            var nd1 = np.arange(9).reshape(3,3).MakeGeneric<double>();

            var nd2 = nd1.matrix_power(3).MakeGeneric<double>();

            var nd3 = nd1.dot(nd1).dot(nd1).MakeGeneric<double>();

            for(int idx = 0; idx < 3;idx++)
                for(int jdx = 0; jdx < 3;jdx++)
                    Assert.IsTrue(nd2[idx,jdx] == nd3[idx,jdx]);
        }
        
    }
}