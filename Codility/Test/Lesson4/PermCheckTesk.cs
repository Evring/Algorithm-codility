using Codility.Lessons.Lesson4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.Lesson4
{
    [TestClass]
    public class PermCheckTesk
    {
        [TestMethod]
        [DataRow(new int[] { 4, 1,3, 2 }, 1)]
        [DataRow(new int[] { 1 }, 1)]
        public void TheArrayIsPermutation(int[] A,int expected)
        {
            var result = new PermCheck().solution(A);
            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //[DataRow(new int[] { 4, 1, 3, 2 }, 1)]
        //[DataRow(new int[] { 1 }, 1)]
        //[DataRow(new int[] { 4, 1, 2 }, 0)]
        //[DataRow(new int[] { 1, 1 }, 0)]
        //[DataRow(new int[] { 2 }, 0)]
        //public void TheArrayIsPermutationSolution2(int[] A, int expected)
        //{
        //    var result = new PermCheck().solution2(A);
        //    Assert.AreEqual(expected, result);
        //}

        [TestMethod]
        [DataRow(new int[] { 4, 1, 2 }, 0)]
        [DataRow(new int[] { 1,1 }, 0)]
        [DataRow(new int[] { 2 }, 0)]
        public void TheArrayIsNotPermutation(int[] A, int expected)
        {
            var result = new PermCheck().solution(A);
            Assert.AreEqual(expected, result);
        }


    }
}
