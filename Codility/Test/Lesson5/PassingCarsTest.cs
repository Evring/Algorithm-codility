using Codility.Lessons.Lesson5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.Lesson5
{
    [TestClass]
    public class PassingCarsTest
    {
        [TestMethod]
        [DataRow(new int[] { 4, 1, 3, 2 }, 1)]
        [DataRow(new int[] { 1 }, 1)]
        public void TheArrayIsPermutation(int[] A, int expected)
        {
            var result = new PassingCars().solution(A);
            Assert.AreEqual(expected, result);
        }

    }
}
