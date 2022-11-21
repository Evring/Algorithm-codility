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
        [DataRow(new int[] {1,2,3 })]
        public void Solution(int[] A)
        {
            var result = new PermCheck().solution(A);
            Assert.AreEqual(1, result);
        }
    }
}
