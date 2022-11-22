using Codility.Lessons.Lesson4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.Lesson4
{
    [TestClass]
    public class MissingIntegerTest
    {
        [TestMethod]

      
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { 2 }, 1)]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [DataRow(new int[] { 1 }, 2)]
        [DataRow(new int[] { 2, 3, 4 }, 1)]
        [DataRow(new int[] { 3, 4, 5 }, 1)]
        [DataRow(new int[] { -1, 4, 5 }, 1)]
        [DataRow(new int[] { 0 }, 1)]
        public void MissingInteger(int[] A, int expected)
        {
            var result = new MissingInteger().solution(A);
            Assert.AreEqual(expected, result);
        }



    }
}
