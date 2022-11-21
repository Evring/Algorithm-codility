using Codility.Lessons.Lesson4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.Lesson4
{
    [TestClass]
    public class MaxCountersTest
    {
        [TestMethod]
        [DataRow(5,new int[] { 3, 4, 4, 6,1,4,4 }, new int[] { 3, 2, 2, 4, 2 })]
        [DataRow(1, new int[] { 1 }, new int[] { 1 })]
        [DataRow(1, new int[] { 1,1,1 }, new int[] { 3 })]
        public void MaxCounters(int N,int[] A, int[] expected)
        {
            var result = new MaxCounters().solution(N,A);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
